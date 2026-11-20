using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class frmSuppliers : Form
    {
        private readonly SupplierController _controller = new();
        private int _editingId = 0;   // 0 = adding, otherwise editing that supplier

        public frmSuppliers()
        {
            InitializeComponent();
            SetupGrid();
            pnlSupplierForm.Visible = false;
            LoadSuppliers();

            btnAddNew.Click += (s, e) => ShowForm(null);
            btnRefresh.Click += (s, e) => { txtSearch.Clear(); LoadSuppliers(); };
            txtSearch.TextChanged += (s, e) => LoadSuppliers();
            btnSave.Click += btnSave_Click;
            btnCancel.Click += (s, e) => HideForm();
            dgvSuppliers.CellContentClick += dgvSuppliers_CellContentClick;
            txtPhone.KeyPress += txtPhone_KeyPress;
        }

        // ---------- Grid ----------
        private void SetupGrid()
        {
            dgvSuppliers.AutoGenerateColumns = false;
            dgvSuppliers.AllowUserToAddRows = false;
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersVisible = false;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddText("Name", "Name", 150);
            AddText("Email", "Email", 140);
            AddText("Phone", "Phone", 90);
            AddText("Address", "Address", 150);
            AddText("ItemCount", "Items", 45);
            AddText("StatusText", "Status", 60);

            dgvSuppliers.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "Action",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                FillWeight = 50
            });
            dgvSuppliers.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                FillWeight = 50
            });
        }

        private void AddText(string prop, string header, float weight) =>
            dgvSuppliers.Columns.Add(new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight });

        private void LoadSuppliers() =>
            dgvSuppliers.DataSource = new BindingList<SupplierModel>(
                _controller.GetAll(txtSearch.Text));

        // ---------- Edit / Delete buttons ----------
        private void dgvSuppliers_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSuppliers.Rows[e.RowIndex].DataBoundItem is not SupplierModel supplier) return;

            string col = dgvSuppliers.Columns[e.ColumnIndex].Name;
            if (col == "colEdit")
            {
                ShowForm(supplier);
            }
            else if (col == "colDelete")
            {
                var ask = MessageBox.Show($"Delete \"{supplier.Name}\"?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask != DialogResult.Yes) return;

                MessageBox.Show(_controller.Remove(supplier.SupplierID), "Supplier");
                LoadSuppliers();
            }
        }

        // ---------- Add / Edit panel ----------
        private void ShowForm(SupplierModel? s)
        {
            _editingId = s?.SupplierID ?? 0;
            lblFormTitle.Text = s == null ? "ADD SUPPLIER" : "EDIT SUPPLIER";

            txtName.Text = s?.Name ?? "";
            txtEmail.Text = s?.Email ?? "";
            txtPhone.Text = s?.Phone ?? "";
            txtAddress.Text = s?.Address ?? "";

            chkActive.Checked = s?.IsActive ?? true;
            chkActive.Visible = s != null;          // only shown when editing

            pnlSupplierForm.Visible = true;
            pnlSupplierForm.BringToFront();
            btnAddNew.Enabled = false;
            txtName.Focus();
        }

        private void HideForm()
        {
            pnlSupplierForm.Visible = false;
            btnAddNew.Enabled = true;
            _editingId = 0;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            var supplier = new SupplierModel
            {
                SupplierID = _editingId,
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                IsActive = chkActive.Checked
            };

            string? error = _controller.Save(supplier);
            if (error != null)
            {
                MessageBox.Show(error, "Cannot save",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(_editingId == 0 ? "Supplier added." : "Supplier updated.", "Success");
            HideForm();
            LoadSuppliers();
        }

        private void txtPhone_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && "+- ".IndexOf(e.KeyChar) < 0)
                e.Handled = true;
        }

        private void btnSupplierProduct_Click(object sender, EventArgs e)
        {
            frmSupplierProduct supplierProduct = new frmSupplierProduct();
            supplierProduct.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard adminDashboard = new frmAdminDashboard();
            adminDashboard.Show();
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