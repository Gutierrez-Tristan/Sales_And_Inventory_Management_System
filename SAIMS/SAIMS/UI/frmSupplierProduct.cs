using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class frmSupplierProduct : Form
    {
        private enum GridMode { Suppliers, Products }

        private readonly SupplierController _supplierController = new();
        private readonly SupplierProductController _productController = new();

        private GridMode? _mode = null;        // what the grid is showing right now
        private SupplierModel? _supplier;      // the chosen supplier
        private int _editingItemId = 0;        // 0 = adding a new item
        private bool _loading = false;         // stops the search box from reloading while we clear it

        public frmSupplierProduct()
        {
            InitializeComponent();

            // Filled by double-clicking, not typed
            txtSupplier.ReadOnly = true;
            txtProduct.ReadOnly = true;
            txtPanelSupplier.ReadOnly = true;

            numUnitCost.DecimalPlaces = 2;
            numUnitCost.Minimum = 0;
            numUnitCost.Maximum = 1000000;

            dgvMain.AutoGenerateColumns = false;
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ReadOnly = true;
            dgvMain.MultiSelect = false;
            dgvMain.RowHeadersVisible = false;
            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Category: pick an existing one OR type a new one
            cboCategory.DropDownStyle = ComboBoxStyle.DropDown;
            cboCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCategory.MaxLength = 100;
            LoadCategories();

            ClearItemPanel();
            SetItemPanelEnabled(false);        // locked until a supplier is chosen

            btnSelectSupplier.Click += btnSelectSupplier_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => { txtProduct.Clear(); ClearItemPanel(); };
            txtSearch.TextChanged += txtSearch_TextChanged;
            dgvMain.CellDoubleClick += dgvMain_CellDoubleClick;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            txtStock.KeyPress += txtStock_KeyPress;
        }

        // =============== SELECT SUPPLIER ===============
        private void btnSelectSupplier_Click(object? sender, EventArgs e)
        {
            ClearSearch();
            ShowSuppliers();
        }

        // =============== GRID: SUPPLIERS VIEW ===============
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
                                               .Where(s => s.IsActive)      // active suppliers only
                                               .ToList();
            dgvMain.DataSource = new BindingList<SupplierModel>(suppliers);
        }

        // =============== GRID: ITEMS VIEW ===============
        private int ShowProducts()
        {
            if (_supplier == null) return 0;

            _mode = GridMode.Products;
            dgvMain.DataSource = null;
            dgvMain.Columns.Clear();
            AddText("ItemName", "Item Name", 170);
            AddText("CategoryName", "Category", 100);
            AddText("UnitPrice", "Unit Cost", 80, "N2");
            AddText("Stock", "Supplier Stock", 80);
            dgvMain.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FillWeight = 60
            });

            var items = _productController.GetBySupplier(_supplier.SupplierID, txtSearch.Text);
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

        // =============== DOUBLE-CLICK ===============
        private void dgvMain_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvMain.Columns[e.ColumnIndex].Name == "colDelete") return;

            object? row = dgvMain.Rows[e.RowIndex].DataBoundItem;

            if (row is SupplierModel supplier)
                ChooseSupplier(supplier);
            else if (row is SupplierProductModel item)
                ChooseProduct(item);
        }

        private void ChooseSupplier(SupplierModel s)
        {
            _supplier = s;
            txtSupplier.Text = s.Name;          // top textbox
            txtPanelSupplier.Text = s.Name;     // right panel textbox
            txtProduct.Clear();
            ClearItemPanel();
            SetItemPanelEnabled(true);

            // Switch the grid after the double-click finishes, so we don't change
            // the grid while it is still handling its own event
            BeginInvoke(new Action(() =>
            {
                ClearSearch();
                int count = ShowProducts();
                if (count == 0)
                    MessageBox.Show("This supplier has no items yet. Fill in the item on the right and press SAVE.",
                                    "Supplier's Products");
            }));
        }

        private void ChooseProduct(SupplierProductModel p)
        {
            _editingItemId = p.SupplierProductID;
            txtProduct.Text = p.ItemName;
            txtItemName.Text = p.ItemName;
            if (p.CategoryID != null) cboCategory.SelectedValue = p.CategoryID.Value;
            else { cboCategory.SelectedIndex = -1; cboCategory.Text = ""; }
            numUnitCost.Value = Math.Min(p.UnitPrice, numUnitCost.Maximum);
            txtStock.Text = p.Stock.ToString();
        }

        // =============== SAVE (ADD OR UPDATE) ===============
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (_supplier == null)
            {
                MessageBox.Show("Please select a supplier first.", "Supplier's Products");
                return;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Supplier stock must be a whole number.", "Cannot save",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new SupplierProductModel
            {
                SupplierProductID = _editingItemId,
                SupplierID = _supplier.SupplierID,
                CategoryName = cboCategory.Text,       // typed or picked: the controller finds or creates it
                ItemName = txtItemName.Text,
                UnitPrice = numUnitCost.Value,
                Stock = stock
            };

            string? error = _productController.Save(item);
            if (error != null)
            {
                MessageBox.Show(error, "Cannot save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(_editingItemId == 0 ? "Item added." : "Item updated.", "Success");
            LoadCategories();                    // so a newly typed category appears in the list
            txtProduct.Clear();
            ClearItemPanel();
            ClearSearch();
            ShowProducts();                      // show the updated list for this supplier
        }

        // =============== DELETE BUTTON IN THE ITEMS VIEW ===============
        private void dgvMain_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _mode != GridMode.Products) return;
            if (dgvMain.Columns[e.ColumnIndex].Name != "colDelete") return;
            if (dgvMain.Rows[e.RowIndex].DataBoundItem is not SupplierProductModel item) return;

            var ask = MessageBox.Show($"Delete \"{item.ItemName}\"?", "Confirm",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask != DialogResult.Yes) return;

            MessageBox.Show(_productController.Delete(item.SupplierProductID), "Supplier's Products");

            if (_editingItemId == item.SupplierProductID)
            {
                txtProduct.Clear();
                ClearItemPanel();
            }
            ShowProducts();
        }

        // =============== SEARCH / REFRESH ===============
        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            if (_loading) return;
            ReloadGrid();
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            ClearSearch();
            if (_mode == null) ShowSuppliers();     // first click shows the suppliers
            else ReloadGrid();
        }

        private void ReloadGrid()
        {
            if (_mode == GridMode.Suppliers) ShowSuppliers();
            else if (_mode == GridMode.Products) ShowProducts();
        }

        private void ClearSearch()
        {
            _loading = true;
            txtSearch.Clear();
            _loading = false;
        }

        // =============== HELPERS ===============
        private void LoadCategories()
        {
            cboCategory.DataSource = null;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DataSource = _productController.GetCategories();
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = "";
        }

        private void ClearItemPanel()
        {
            _editingItemId = 0;
            txtItemName.Clear();
            cboCategory.SelectedIndex = -1;
            cboCategory.Text = "";
            numUnitCost.Value = 0;
            txtStock.Text = "0";
        }

        private void SetItemPanelEnabled(bool enabled)
        {
            txtItemName.Enabled = enabled;
            cboCategory.Enabled = enabled;
            numUnitCost.Enabled = enabled;
            txtStock.Enabled = enabled;
            btnSave.Enabled = enabled;
        }

        private void txtStock_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProductManagement productManagement = new frmProductManagement();
            productManagement.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Logout(this);
        }
    }
}