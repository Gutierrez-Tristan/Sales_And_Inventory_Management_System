using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class POS : Form
    {
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
            txtVat.ReadOnly = true;
            txtTotal.ReadOnly = true;
            txtPayTotal.ReadOnly = true;
            txtPayChange.ReadOnly = true;

            // discount type: None / Senior Citizen / PWD
            cboDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDiscount.Items.AddRange(SaleCalculator.DiscountTypes);
            cboDiscount.SelectedIndex = 0;

            // mode of payment: Cash / GCash / Card
            cboPayMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPayMethod.Items.AddRange(PaymentTypes.All);
            cboPayMethod.SelectedIndex = 0;

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
            cboDiscount.SelectedIndexChanged += (s, e) => RecalcTotals();

            // payment panel
            cboPayMethod.SelectedIndexChanged += (s, e) => ApplyPayMethod();
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
        private string SelectedDiscountType => cboDiscount.SelectedItem?.ToString() ?? "None";
        private string SelectedPayMethod => cboPayMethod.SelectedItem?.ToString() ?? "Cash";

        private void RecalcTotals()
        {
            decimal subtotal = _cart.Sum(c => c.LineTotal);
            string type = SelectedDiscountType;
            decimal discount = SaleCalculator.DiscountFor(subtotal, type);
            var t = SaleCalculator.Compute(subtotal, discount, SaleCalculator.VatRateFor(type));

            _total = t.Total;
            txtSubtotal.Text = subtotal.ToString("N2");
            txtVat.Text = t.Vat.ToString("N2");
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
        // Cash: the cashier types the amount received.
        // GCash / Card: the exact total is paid, so the amount is filled in and locked.
        private void ApplyPayMethod()
        {
            bool cash = PaymentTypes.IsCash(SelectedPayMethod);
            txtPayAmount.Enabled = cash;

            if (cash)
            {
                txtPayAmount.Clear();
                txtPayAmount.Focus();
            }
            else
            {
                txtPayAmount.Text = _total.ToString("0.00");
            }
            RecalcChange();
        }

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

            txtPayTotal.Text = _total.ToString("N2");
            txtPayChange.Text = "0.00";

            pnlPayment.Visible = true;
            pnlPayment.BringToFront();
            SetBusy(true);

            cboPayMethod.SelectedIndex = 0;     // every sale starts on Cash
            ApplyPayMethod();
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
                DiscountType = SelectedDiscountType,   // the controller works out the discount and VAT
                PaymentMethod = SelectedPayMethod,
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

            ReceiptPrinter.ShowPreview(this, _lastSale!, _lastSaleId, _lastDate,
                                       UserSession.Current?.Username ?? "");   // the receipt opens in Print Preview
            txtSearch.Focus();
        }

        // =============== HELPERS ===============
        private void ResetSale()
        {
            _cart.Clear();
            cboDiscount.SelectedIndex = 0;
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
            cboDiscount.Enabled = !busy;
        }

        private void MoneyOnly(object? sender, KeyPressEventArgs e)
        {
            bool ok = char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) ||
                      (e.KeyChar == '.' && sender is TextBox tb && !tb.Text.Contains('.'));
            if (!ok) e.Handled = true;
        }

        // =============== NAVIGATION ===============
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