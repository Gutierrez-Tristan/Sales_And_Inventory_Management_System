using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class StockInquiry : Form
    {
        private readonly ProductController _controller = new();
        private bool _loading = false;      // stops reloads while we reset the filters

        public StockInquiry()
        {
            InitializeComponent();

            SetupGrid();

            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.Items.AddRange(new object[] { "All", "OK", "Low", "Out of stock" });
            cboStatus.SelectedIndex = 0;

            LoadStock();

            txtSearch.TextChanged += (s, e) => { if (!_loading) LoadStock(); };
            cboStatus.SelectedIndexChanged += (s, e) => { if (!_loading) LoadStock(); };
            btnRefresh.Click += btnRefresh_Click;
            dgvStock.CellFormatting += dgvStock_CellFormatting;
            Activated += (s, e) => LoadStock();     // pick up sales made while this form was hidden
        }

        // =============== GRID ===============
        private void SetupGrid()
        {
            dgvStock.AutoGenerateColumns = false;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.ReadOnly = true;
            dgvStock.MultiSelect = false;
            dgvStock.RowHeadersVisible = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddText("ItemName", "Product", 200);
            AddText("CategoryName", "Category", 120);
            AddText("SellingPrice", "Price", 80, "N2");
            AddText("Stock", "In Stock", 70);
            AddText("ReorderLevel", "Reorder Level", 90);
            AddText("StockStatus", "Status", 100);
        }

        private void AddText(string prop, string header, float weight, string? format = null)
        {
            var col = new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvStock.Columns.Add(col);
        }

        // =============== LOAD ===============
        private void LoadStock()
        {
            string status = cboStatus.SelectedItem?.ToString() ?? "All";
            var list = _controller.GetInventory(txtSearch.Text, status);

            dgvStock.DataSource = new BindingList<ProductModel>(list);

            int low = list.Count(p => p.StockStatus == "Low");
            int outOfStock = list.Count(p => p.StockStatus == "Out of stock");
            lblSummary.Text = $"{list.Count} product(s)   |   {low} low   |   {outOfStock} out of stock";
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            _loading = true;
            txtSearch.Clear();
            cboStatus.SelectedIndex = 0;
            _loading = false;
            LoadStock();
        }

        // Red = out of stock, orange = low
        private void dgvStock_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string prop = dgvStock.Columns[e.ColumnIndex].DataPropertyName;
            if (prop != "Stock" && prop != "StockStatus") return;
            if (dgvStock.Rows[e.RowIndex].DataBoundItem is not ProductModel p) return;

            if (p.StockStatus == "Out of stock")
            {
                e.CellStyle.ForeColor = Color.Red;
                e.CellStyle.Font = new Font(dgvStock.Font, FontStyle.Bold);
            }
            else if (p.StockStatus == "Low")
            {
                e.CellStyle.ForeColor = Color.DarkOrange;
                e.CellStyle.Font = new Font(dgvStock.Font, FontStyle.Bold);
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CashierDashboard frmCashierDashboard = new CashierDashboard();
            frmCashierDashboard.Show();
            this.Hide();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS frmPOS = new POS();
            frmPOS.Show();
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