using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class Transaction : Form
    {
        private readonly SaleController _saleController = new();
        private bool _loading = false;      // stops search from reloading while we clear it

        public Transaction()
        {
            InitializeComponent();

            SetupGrid();
            LoadTransactions();

            txtSearch.TextChanged += (s, e) => { if (!_loading) LoadTransactions(); };
            btnRefresh.Click += btnRefresh_Click;
            btnViewReceipt.Click += (s, e) => ViewReceipt();
            dgvTransactions.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) ViewReceipt(); };
        }

        // =============== GRID ===============
        private void SetupGrid()
        {
            dgvTransactions.AutoGenerateColumns = false;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.ReadOnly = true;
            dgvTransactions.MultiSelect = false;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddText("SaleID", "Sale #", 60);
            AddText("SaleDate", "Date", 130, "dd/MM/yyyy hh:mm tt");
            AddText("CashierName", "Cashier", 90);
            AddText("ItemCount", "Items", 50);
            AddText("Subtotal", "Subtotal", 80, "N2");
            AddText("Discount", "Discount", 70, "N2");
            AddText("Total", "Total", 80, "N2");
            AddText("AmountPaid", "Paid", 80, "N2");
            AddText("ChangeAmount", "Change", 70, "N2");
        }

        private void AddText(string prop, string header, float weight, string? format = null)
        {
            var col = new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvTransactions.Columns.Add(col);
        }

        private void LoadTransactions()
        {
            dgvTransactions.DataSource = new BindingList<SaleSummaryModel>(
                _saleController.GetTransactions(txtSearch.Text));
        }

        // =============== BUTTONS ===============
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            _loading = true;
            txtSearch.Clear();
            _loading = false;
            LoadTransactions();
        }

        private void ViewReceipt()
        {
            if (dgvTransactions.CurrentRow?.DataBoundItem is not SaleSummaryModel row)
            {
                MessageBox.Show("Select a transaction first.", "Transaction");
                return;
            }

            SaleModel? sale = _saleController.GetSale(row.SaleID);
            if (sale == null)
            {
                MessageBox.Show("This sale could not be found.", "Transaction");
                return;
            }

            ReceiptPrinter.ShowPreview(this, sale, row.SaleID, row.SaleDate, row.CashierName);
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
        private void btnStockInquiry_Click_1(object sender, EventArgs e)
        {
            StockInquiry frmStockInquiry = new StockInquiry();
            frmStockInquiry.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionHelper.Logout(this);
        }
    }
}