using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class frmProductManagement : Form
    {
        private enum GridMode { Store, Suppliers, SupplierItems }

        private readonly SupplierController _supplierController = new();
        private readonly SupplierProductController _supplierProductController = new();
        private readonly ProductController _productController = new();

        private GridMode _mode = GridMode.Store;
        private SupplierModel? _supplier;              // chosen supplier
        private SupplierProductModel? _supplierItem;   // chosen supplier item
        private ProductModel? _restocking;             // product being restocked
        private bool _loading = false;                 // stops search from reloading while we clear it

        public frmProductManagement()
        {
            InitializeComponent();

            // Filled by double-clicking, not typed
            foreach (var t in new[] { txtSupplier, txtProduct, txtAddSupplier, txtAddItem, txtAddCategory,
                                      txtRsProduct, txtRsSupplier, txtRsCategory,
                                      txtRsStoreStock, txtRsSupplierStock })
                t.ReadOnly = true;

            numCostPrice.DecimalPlaces = 2; numCostPrice.Maximum = 1000000;
            numCostPrice.ReadOnly = true;          // cost comes from the supplier's unit price
            numCostPrice.InterceptArrowKeys = false;
            numSellingPrice.DecimalPlaces = 2; numSellingPrice.Maximum = 1000000;
            numRsCost.DecimalPlaces = 2; numRsCost.Maximum = 1000000;
            numRsTotal.DecimalPlaces = 2; numRsTotal.Maximum = 1000000000;
            numRsTotal.ReadOnly = true;            // computed: cost x quantity
            numRsTotal.InterceptArrowKeys = false;

            dgvMain.AutoGenerateColumns = false;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ReadOnly = true;
            dgvMain.MultiSelect = false;
            dgvMain.RowHeadersVisible = false;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Popup panels: centered, hidden until needed
            CenterPanels();
            pnlAddProduct.Visible = false;
            pnlRestock.Visible = false;
            Resize += (s, e) => CenterPanels();

            ShowStore();

            btnSelectSupplier.Click += (s, e) => { ClearSearch(); ShowSuppliers(); };
            btnAddProductToStore.Click += btnAddProductToStore_Click;
            btnRefresh.Click += btnRefresh_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;

            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            dgvMain.CellFormatting += dgvMain_CellFormatting;

            btnAddSave.Click += btnAddSave_Click;
            btnAddCancel.Click += (s, e) => HidePanels();

            txtRsQty.TextChanged += (s, e) => RecalcTotal();
            numRsCost.ValueChanged += (s, e) => RecalcTotal();
            btnConfirm.Click += btnConfirm_Click;
            btnRestockCancel.Click += (s, e) => HidePanels();

            txtOpeningStock.KeyPress += DigitsOnly;
            txtReorderLevel.KeyPress += DigitsOnly;
            txtRsQty.KeyPress += DigitsOnly;
        }

        // =============== PANEL POSITION ===============
        // Centers each popup panel inside its own parent container
        private void CenterPanels()
        {
            CenterInParent(pnlAddProduct);
            CenterInParent(pnlRestock);
        }

        private void CenterInParent(Control panel)
        {
            var host = panel.Parent ?? this;
            panel.Left = (host.ClientSize.Width - panel.Width) / 2;
            panel.Top = (host.ClientSize.Height - panel.Height) / 2;
        }

        // =============== GRID: STORE PRODUCTS (default view) ===============
        private void ShowStore()
        {
            _mode = GridMode.Store;
            dgvMain.DataSource = null;
            dgvMain.Columns.Clear();
            AddText("ItemName", "Product", 140);
            AddText("CategoryName", "Category", 90);
            AddText("SupplierName", "Supplier", 100);
            AddText("CostPrice", "Cost", 60, "N2");
            AddText("SellingPrice", "Price", 60, "N2");
            AddText("Stock", "Stock", 50);
            AddText("ReorderLevel", "Reorder", 55);
            AddText("StockStatus", "Status", 75);
            dgvMain.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colRestock",
                HeaderText = "",
                Text = "Restock",
                UseColumnTextForButtonValue = true,
                FillWeight = 70
            });

            dgvMain.DataSource = new BindingList<ProductModel>(
                _productController.GetAll(txtSearch.Text));
        }

        // =============== GRID: SUPPLIERS ===============
        private void ShowSuppliers()
        {
            _mode = GridMode.Suppliers;
            dgvMain.DataSource = null;
            dgvMain.Columns.Clear();
            AddText("Name", "Supplier", 150);
            AddText("Email", "Email", 140);
            AddText("Phone", "Phone", 90);
            AddText("Address", "Address", 140);
            AddText("ItemCount", "Items", 45);

            var suppliers = _supplierController.GetAll(txtSearch.Text)
                                               .Where(s => s.IsActive)
                                               .ToList();
            dgvMain.DataSource = new BindingList<SupplierModel>(suppliers);
        }

        // =============== GRID: SUPPLIER'S ITEMS ===============
        private int ShowSupplierItems()
        {
            if (_supplier == null) return 0;

            _mode = GridMode.SupplierItems;
            dgvMain.DataSource = null;
            dgvMain.Columns.Clear();
            AddText("ItemName", "Item Name", 170);
            AddText("CategoryName", "Category", 100);
            AddText("UnitPrice", "Unit Cost", 80, "N2");
            AddText("Stock", "Supplier Stock", 80);

            var items = _supplierProductController.GetBySupplier(_supplier.SupplierID, txtSearch.Text);
            dgvMain.DataSource = new BindingList<SupplierProductModel>(items);
            return items.Count;
        }

        private void AddText(string prop, string header, float weight, string? format = null)
        {
            var col = new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvMain.Columns.Add(col);
        }

        // Colour the Status cell (Low / Out of stock)
        private void dgvMain_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_mode != GridMode.Store || e.RowIndex < 0) return;
            if (dgvMain.Columns[e.ColumnIndex].DataPropertyName != "StockStatus") return;

            string text = e.Value?.ToString() ?? "";
            if (text == "Low")
                e.CellStyle.ForeColor = Color.DarkOrange;
            else if (text == "Out of stock")
                e.CellStyle.ForeColor = Color.Red;
        }

        // =============== DOUBLE-CLICK ===============
        private void dgvMain_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            object? row = dgvMain.Rows[e.RowIndex].DataBoundItem;

            if (row is SupplierModel supplier)
                ChooseSupplier(supplier);
            else if (row is SupplierProductModel item)
                ChooseItem(item);
        }

        private void ChooseSupplier(SupplierModel s)
        {
            _supplier = s;
            _supplierItem = null;
            txtSupplier.Text = s.Name;
            txtProduct.Clear();

            // Switch the grid after the double-click finishes
            BeginInvoke(new Action(() =>
            {
                ClearSearch();
                if (ShowSupplierItems() == 0)
                    MessageBox.Show("This supplier has no items yet. Add them in Supplier's Products.",
                                    "Product Management");
            }));
        }

        private void ChooseItem(SupplierProductModel item)
        {
            _supplierItem = item;
            txtProduct.Text = item.ItemName;
        }

        // =============== ADD PRODUCT TO THE STORE ===============
        private void btnAddProductToStore_Click(object? sender, EventArgs e)
        {
            if (_supplier == null || _supplierItem == null)
            {
                MessageBox.Show("Select a supplier, then double-click one of its items first.",
                                "Product Management");
                return;
            }

            if (_productController.IsInStore(_supplierItem.SupplierProductID))
            {
                MessageBox.Show("This item is already in the store. Use Restock on the product list instead.",
                                "Product Management");
                return;
            }

            txtAddSupplier.Text = _supplier.Name;
            txtAddItem.Text = _supplierItem.ItemName;
            txtAddCategory.Text = _supplierItem.CategoryName;
            numCostPrice.Value = Math.Min(_supplierItem.UnitPrice, numCostPrice.Maximum);  // supplier's unit price
            numSellingPrice.Value = 0;
            txtOpeningStock.Text = "0";
            txtReorderLevel.Text = "0";

            pnlRestock.Visible = false;
            CenterPanels();
            pnlAddProduct.Visible = true;
            pnlAddProduct.BringToFront();
            SetBusy(true);
        }

        private void btnAddSave_Click(object? sender, EventArgs e)
        {
            if (_supplierItem == null) return;

            if (!int.TryParse(txtOpeningStock.Text.Trim(), out int opening) ||
                !int.TryParse(txtReorderLevel.Text.Trim(), out int reorder))
            {
                MessageBox.Show("Opening stock and reorder level must be whole numbers.",
                                "Cannot save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new ProductModel
            {
                SupplierProductID = _supplierItem.SupplierProductID,
                CostPrice = numCostPrice.Value,
                SellingPrice = numSellingPrice.Value,
                ReorderLevel = reorder
            };

            string? error = _productController.Add(product, opening);
            if (error != null)
            {
                MessageBox.Show(error, "Cannot save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Product added to the store.", "Success");
            HidePanels();
            ResetSelection();
            ClearSearch();
            ShowStore();
        }

        // =============== RESTOCK ===============
        private void dgvMain_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _mode != GridMode.Store) return;
            if (dgvMain.Columns[e.ColumnIndex].Name != "colRestock") return;
            if (dgvMain.Rows[e.RowIndex].DataBoundItem is not ProductModel p) return;

            _restocking = p;
            txtRsProduct.Text = p.ItemName;
            txtRsSupplier.Text = p.SupplierName;
            txtRsCategory.Text = p.CategoryName;
            txtRsStoreStock.Text = p.Stock.ToString();
            txtRsSupplierStock.Text = p.SupplierStock.ToString();
            numRsCost.Value = Math.Min(p.SupplierUnitPrice, numRsCost.Maximum);  // supplier's current cost
            txtRsQty.Text = "";
            RecalcTotal();

            pnlAddProduct.Visible = false;
            CenterPanels();
            pnlRestock.Visible = true;
            pnlRestock.BringToFront();
            SetBusy(true);
        }

        private void RecalcTotal()
        {
            int.TryParse(txtRsQty.Text.Trim(), out int qty);
            numRsTotal.Value = Math.Min(numRsCost.Value * qty, numRsTotal.Maximum);
        }

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            if (_restocking == null) return;

            if (!int.TryParse(txtRsQty.Text.Trim(), out int qty))
            {
                MessageBox.Show("Quantity to buy must be a whole number.",
                                "Cannot restock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? error = _productController.Restock(_restocking.ProductID, qty, numRsCost.Value);
            if (error != null)
            {
                MessageBox.Show(error, "Cannot restock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Restocked {qty} unit(s) of {_restocking.ItemName}.", "Success");
            HidePanels();
            ClearSearch();
            ShowStore();
        }

        // =============== SEARCH / REFRESH ===============
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            switch (_mode)
            {
                case GridMode.Store: ShowStore(); break;
                case GridMode.Suppliers: ShowSuppliers(); break;
                case GridMode.SupplierItems: ShowSupplierItems(); break;
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            ClearSearch();
            ResetSelection();
            ShowStore();
        }

        // =============== HELPERS ===============
        private void ClearSearch()
        {
            _loading = true;
            txtSearch.Clear();
            _loading = false;
        }

        private void ResetSelection()
        {
            _supplier = null;
            _supplierItem = null;
            txtSupplier.Clear();
            txtProduct.Clear();
        }

        private void HidePanels()
        {
            pnlAddProduct.Visible = false;
            pnlRestock.Visible = false;
            _restocking = null;
            SetBusy(false);
        }

        // Lock the screen behind a popup panel
        private void SetBusy(bool busy)
        {
            btnSelectSupplier.Enabled = !busy;
            btnAddProductToStore.Enabled = !busy;
            btnRefresh.Enabled = !busy;
            txtSearch.Enabled = !busy;
            dgvMain.Enabled = !busy;
        }

        private void DigitsOnly(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // =============== NAVIGATION ===============
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers suppliers = new frmSuppliers();
            suppliers.Show();
            this.Hide();
        }

        private void btnSupplierProduct_Click(object sender, EventArgs e)
        {
            frmSupplierProduct supplierProduct = new frmSupplierProduct();
            supplierProduct.Show();
            this.Hide();
        }

        // Empty handlers kept because the designer may still point to them
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void txtProduct_TextChanged(object sender, EventArgs e) { }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) { }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Logout(this);
        }
    }
}