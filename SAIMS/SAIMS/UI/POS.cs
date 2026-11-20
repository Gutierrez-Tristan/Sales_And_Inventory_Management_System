using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class POS : Form
    {
        // ---- edit these for your store ----
        private const string StoreName = "INVEXA";
        private const string StoreTagline = "Sales and Inventory System";
        private const string StoreAddress = "123 Sample Street, City";
        private const string StoreContact = "Tel: 0900 000 0000";
        private const float LogoHeight = 80;       // printed logo height (1/100 inch)
        private const bool LogoGrayscale = false;   // false = colour logo, true = grey (best for thermal printers)
        private const bool ThermalPaper = true;    // true = 80 mm roll, false = normal A4/Letter

        private const float ReceiptWidth = 315;       // 80 mm in 1/100 inch

        private readonly ProductController _productController = new();
        private readonly SaleController _saleController = new();
        private readonly BindingList<SaleItemModel> _cart = new();
        private decimal _total = 0;

        // last completed sale (used for the receipt)
        private SaleModel? _lastSale;
        private int _lastSaleId;
        private DateTime _lastDate;

        public POS()
        {
            InitializeComponent();

            numQty.Minimum = 1;
            numQty.Maximum = 10000;
            numQty.Value = 1;

            txtSubtotal.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtPayTotal.ReadOnly = true;
            txtPayChange.ReadOnly = true;

            pnlPayment.Visible = false;

            SetupGrids();
            LoadProducts();
            RecalcTotals();

            // main screen
            txtSearch.TextChanged += (s, e) => LoadProducts();
            btnAddToCart.Click += (s, e) => AddToCart();
            dgvProducts.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) AddToCart(); };
            btnRemoveItem.Click += btnRemoveItem_Click;
            btnClear.Click += btnClear_Click;
            btnCheckout.Click += btnCheckout_Click;
            txtDiscount.TextChanged += (s, e) => RecalcTotals();
            txtDiscount.KeyPress += MoneyOnly;

            // payment panel
            txtPayAmount.TextChanged += (s, e) => RecalcChange();
            txtPayAmount.KeyPress += MoneyOnly;
            btnPayConfirm.Click += btnPayConfirm_Click;
            btnPayCancel.Click += (s, e) => ClosePayment();
        }

        // =============== GRIDS ===============
        private void SetupGrids()
        {
            foreach (var dgv in new[] { dgvProducts, dgvCart })
            {
                dgv.AutoGenerateColumns = false;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
                dgv.MultiSelect = false;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Products
            AddText(dgvProducts, "ItemName", "Product", 200);
            AddText(dgvProducts, "CategoryName", "Category", 110);
            AddText(dgvProducts, "SellingPrice", "Price", 80, "N2");
            AddText(dgvProducts, "Stock", "In Stock", 70);

            // Cart
            AddText(dgvCart, "ItemName", "Item", 200);
            AddText(dgvCart, "UnitPrice", "Price", 80, "N2");
            AddText(dgvCart, "Quantity", "Qty", 60);
            AddText(dgvCart, "LineTotal", "Amount", 90, "N2");
            dgvCart.DataSource = _cart;
        }

        private static void AddText(DataGridView dgv, string prop, string header,
                                    float weight, string? format = null)
        {
            var col = new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgv.Columns.Add(col);
        }

        private void LoadProducts() =>
            dgvProducts.DataSource = new BindingList<ProductModel>(
                _productController.GetForSale(txtSearch.Text));

        // =============== CART ===============
        private void AddToCart()
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is not ProductModel p)
            {
                MessageBox.Show("Select a product first.", "POS");
                return;
            }

            int qty = (int)numQty.Value;
            var line = _cart.FirstOrDefault(c => c.ProductID == p.ProductID);
            int inCart = line?.Quantity ?? 0;

            if (inCart + qty > p.Stock)
            {
                MessageBox.Show($"Only {p.Stock} in stock ({inCart} already in the cart).",
                                "Not enough stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (line == null)
            {
                _cart.Add(new SaleItemModel
                {
                    ProductID = p.ProductID,
                    ItemName = p.ItemName,
                    UnitPrice = p.SellingPrice,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
                _cart.ResetBindings();      // refresh Qty and Amount in the grid
            }

            numQty.Value = 1;
            RecalcTotals();
        }

        private void btnRemoveItem_Click(object? sender, EventArgs e)
        {
            if (dgvCart.CurrentRow?.DataBoundItem is not SaleItemModel item)
            {
                MessageBox.Show("Select an item in the cart first.", "POS");
                return;
            }
            _cart.Remove(item);
            RecalcTotals();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            if (_cart.Count == 0) return;
            var ask = MessageBox.Show("Clear the whole cart?", "Confirm",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes) ResetSale();
        }

        // =============== TOTALS ===============
        private void RecalcTotals()
        {
            decimal subtotal = _cart.Sum(c => c.LineTotal);
            decimal discount = ParseMoney(txtDiscount.Text);

            _total = Math.Max(subtotal - discount, 0);
            txtSubtotal.Text = subtotal.ToString("N2");
            txtTotal.Text = _total.ToString("N2");
        }

        private void RecalcChange()
        {
            decimal paid = ParseMoney(txtPayAmount.Text);
            txtPayChange.Text = paid >= _total ? (paid - _total).ToString("N2") : "0.00";
        }

        private static decimal ParseMoney(string text) =>
            decimal.TryParse(text.Trim(), out var v) ? v : 0;

        // =============== PAYMENT PANEL ===============
        private void btnCheckout_Click(object? sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("The cart is empty.", "POS");
                return;
            }
            if (UserSession.Current == null)
            {
                MessageBox.Show("No cashier is logged in.", "POS");
                return;
            }
            if (ParseMoney(txtDiscount.Text) > _cart.Sum(c => c.LineTotal))
            {
                MessageBox.Show("Discount cannot be more than the subtotal.", "POS");
                return;
            }

            txtPayTotal.Text = _total.ToString("N2");
            txtPayAmount.Clear();
            txtPayChange.Text = "0.00";

            pnlPayment.Visible = true;
            pnlPayment.BringToFront();
            SetBusy(true);
            txtPayAmount.Focus();
        }

        private void ClosePayment()
        {
            pnlPayment.Visible = false;
            SetBusy(false);
        }

        private void btnPayConfirm_Click(object? sender, EventArgs e)
        {
            var sale = new SaleModel
            {
                CashierID = (int)(UserSession.Current?.Id ?? 0),
                Discount = ParseMoney(txtDiscount.Text),
                AmountPaid = ParseMoney(txtPayAmount.Text),
                Items = _cart.ToList()
            };

            string? error = _saleController.Checkout(sale, out int saleId);
            if (error != null)
            {
                MessageBox.Show(error, "Cannot checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;      // stay on the payment panel
            }

            // Keep the sale for the receipt BEFORE the cart is cleared
            _lastSale = sale;
            _lastSaleId = saleId;
            _lastDate = DateTime.Now;

            // Get the screen ready for the next customer
            pnlPayment.Visible = false;
            SetBusy(false);
            ResetSale();
            LoadProducts();                 // show the updated stock

            ShowPrintPreview();             // the receipt opens in Print Preview
            txtSearch.Focus();
        }

        // =============== PRINT PREVIEW ===============
        private void ShowPrintPreview()
        {
            if (_lastSale == null) return;

            try
            {
                var doc = new PrintDocument();

                if (ThermalPaper)
                {
                    // 80 mm roll. Height fits the content.
                    int height = (int)DrawReceipt(null) + 20;
                    doc.DefaultPageSettings.PaperSize = new PaperSize("Receipt80mm", (int)ReceiptWidth, height);
                    doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                }

                doc.PrintPage += (s, ev) =>
                {
                    var g = ev.Graphics!;

                    // Center the receipt on whatever paper the printer really uses
                    // (e.g. "Microsoft Print to PDF" uses a full Letter page)
                    float x = (ev.PageBounds.Width - ReceiptWidth) / 2f - ev.PageSettings.HardMarginX;
                    g.TranslateTransform(Math.Max(x, 0), 0);

                    DrawReceipt(g);
                    ev.HasMorePages = false;
                };

                using var preview = new PrintPreviewDialog
                {
                    Document = doc,
                    UseAntiAlias = true,
                    WindowState = FormWindowState.Maximized,
                    StartPosition = FormStartPosition.CenterScreen,
                    Text = "Print preview"
                };
                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not show the receipt: " + ex.Message, "Print");
            }
        }

        // Draws the receipt. Pass null to only measure it. Returns the final height.
        // Units are 1/100 inch, which is what printers use.
        private float DrawReceipt(Graphics? g)
        {
            var sale = _lastSale;
            if (sale == null) return 0;

            const float L = 10, CW = 295;   // left margin, content width
            float y = 10;

            using var fBody = new Font("Consolas", 8);
            using var fBold = new Font("Consolas", 8, FontStyle.Bold);
            using var fSmall = new Font("Consolas", 7);
            using var fTitle = new Font("Consolas", 14, FontStyle.Bold);
            using var fTotal = new Font("Consolas", 11, FontStyle.Bold);

            void Put(string s, Font f, StringAlignment a, float h,
                     float x = L, float w = CW, Brush? b = null)
            {
                if (g == null) return;
                using var sf = new StringFormat
                {
                    Alignment = a,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                g.DrawString(s, f, b ?? Brushes.Black, new RectangleF(x, y, w, h), sf);
            }

            void Center(string s, Font f, float h) { Put(s, f, StringAlignment.Center, h); y += h; }

            void Pair(string left, string right, Font f, float h = 14)
            {
                Put(left, f, StringAlignment.Near, h);
                Put(right, f, StringAlignment.Far, h);
                y += h;
            }

            void Dash()
            {
                if (g != null)
                {
                    using var pen = new Pen(Color.Black) { DashStyle = DashStyle.Dash };
                    g.DrawLine(pen, L, y + 4, L + CW, y + 4);
                }
                y += 10;
            }

            // ----- header with logo (Resources/ddd.png) -----
            var logo = Properties.Resources.ddd;
            if (logo != null)
            {
                float logoW = LogoHeight * logo.Width / logo.Height;   // keep the proportions
                if (g != null)
                {
                    var dest = new Rectangle((int)((ReceiptWidth - logoW) / 2f), (int)y,
                                             (int)logoW, (int)LogoHeight);
                    using var attrs = new ImageAttributes();
                    if (LogoGrayscale)
                    {
                        attrs.SetColorMatrix(new ColorMatrix(new[]
                        {
                            new[] { 0.30f, 0.30f, 0.30f, 0f, 0f },
                            new[] { 0.59f, 0.59f, 0.59f, 0f, 0f },
                            new[] { 0.11f, 0.11f, 0.11f, 0f, 0f },
                            new[] { 0f,    0f,    0f,    1f, 0f },
                            new[] { 0f,    0f,    0f,    0f, 1f }
                        }));
                    }
                    g.DrawImage(logo, dest, 0, 0, logo.Width, logo.Height, GraphicsUnit.Pixel, attrs);
                }
                y += LogoHeight + 6;                        // counted in the measuring pass too
            }

            Center(StoreName, fTitle, 26);
            Center(StoreTagline, fSmall, 12);
            Center(StoreAddress, fSmall, 12);
            Center(StoreContact, fSmall, 12);
            Dash();

            // ----- sale info -----
            Pair("Sale #", _lastSaleId.ToString(), fBody);
            Pair("Date", _lastDate.ToString("dd/MM/yyyy hh:mm tt"), fBody);
            Pair("Cashier", UserSession.Current?.Username ?? "", fBody);
            Dash();

            // ----- items -----
            Put("ITEM", fBold, StringAlignment.Near, 14, L, 165);
            Put("QTY", fBold, StringAlignment.Center, 14, 175, 40);
            Put("AMOUNT", fBold, StringAlignment.Far, 14, 215, 90);
            y += 16;

            foreach (var i in sale.Items)
            {
                Put(i.ItemName, fBody, StringAlignment.Near, 14, L, 165);
                Put(i.Quantity.ToString(), fBody, StringAlignment.Center, 14, 175, 40);
                Put(i.LineTotal.ToString("N2"), fBody, StringAlignment.Far, 14, 215, 90);
                y += 14;

                if (i.Quantity > 1)
                {
                    Put($"  @ {i.UnitPrice:N2}", fSmall, StringAlignment.Near, 12, L, CW, Brushes.Gray);
                    y += 12;
                }
            }
            Dash();

            // ----- totals -----
            Pair("Subtotal", sale.Subtotal.ToString("N2"), fBody);
            Pair("Discount", Math.Round(sale.Discount, 2) > 0 ? "-" + sale.Discount.ToString("N2") : "0.00", fBody);
            Pair("TOTAL", sale.Total.ToString("N2"), fTotal, 22);
            Pair("Amount Paid", sale.AmountPaid.ToString("N2"), fBody);
            Pair("Change", sale.ChangeAmount.ToString("N2"), fBody);
            Dash();

            // ----- footer -----
            Center("Thank you for shopping!", fBold, 16);
            Center("Please come again", fSmall, 12);

            return y;
        }

        // =============== HELPERS ===============
        private void ResetSale()
        {
            _cart.Clear();
            txtDiscount.Clear();
            numQty.Value = 1;
            RecalcTotals();
        }

        // Lock the main screen while the payment popup is open
        private void SetBusy(bool busy)
        {
            txtSearch.Enabled = !busy;
            dgvProducts.Enabled = !busy;
            dgvCart.Enabled = !busy;
            numQty.Enabled = !busy;
            btnAddToCart.Enabled = !busy;
            btnRemoveItem.Enabled = !busy;
            btnClear.Enabled = !busy;
            btnCheckout.Enabled = !busy;
            txtDiscount.Enabled = !busy;
        }

        private void MoneyOnly(object? sender, KeyPressEventArgs e)
        {
            bool ok = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                      (e.KeyChar == '.' && sender is TextBox tb && !tb.Text.Contains('.'));
            if (!ok) e.Handled = true;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CashierDashboard frmCashierDashboard = new CashierDashboard();
            frmCashierDashboard.Show();
            this.Hide();
        }

        private void btnStockInquiry_Click(object sender, EventArgs e)
        {
            StockInquiry frmStockInquiry = new StockInquiry();
            frmStockInquiry.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transaction frmTransaction = new Transaction();
            frmTransaction.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Logout(this);
        }
    }
}