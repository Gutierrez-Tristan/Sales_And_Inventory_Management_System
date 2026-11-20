using System.ComponentModel;
using SAIMS.BusinessLogic;
using SAIMS.Model;

namespace SAIMS.UI
{
    public partial class CashierDashboard : Form
    {
        private readonly DashboardController _controller = new();

        public CashierDashboard()
        {
            InitializeComponent();

            SetupGrid();
            LoadDashboard();

            btnReload.Click += (s, e) => LoadDashboard();
            Activated += (s, e) => LoadDashboard();     // refresh when you come back from POS
        }

        // =============== GRID ===============
        private void SetupGrid()
        {
            dgvRecent.AutoGenerateColumns = false;
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.ReadOnly = true;
            dgvRecent.MultiSelect = false;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AddText("SaleID", "Sale #", 60);
            AddText("SaleDate", "Time", 80, "hh:mm tt");
            AddText("ItemCount", "Items", 60);
            AddText("Total", "Total", 90, "N2");
            AddText("AmountPaid", "Paid", 90, "N2");
            AddText("ChangeAmount", "Change", 90, "N2");
        }

        private void AddText(string prop, string header, float weight, string? format = null)
        {
            var col = new DataGridViewTextBoxColumn
            { DataPropertyName = prop, HeaderText = header, FillWeight = weight };
            if (format != null) col.DefaultCellStyle.Format = format;
            dgvRecent.Columns.Add(col);
        }

        // =============== LOAD ===============
        private void LoadDashboard()
        {
            int cashierId = (int)(UserSession.Current?.Id ?? 0);

            try
            {
                var s = _controller.GetCashierSummary(cashierId);
                SetCard(lblSalesToday, "SALES TODAY", s.SalesToday.ToString("N2"));
                SetCard(lblTransactions, "TRANSACTIONS", s.TransactionsToday.ToString());
                SetCard(lblItemsSold, "ITEMS SOLD", s.ItemsSold.ToString());
                SetCard(lblLowStock, "LOW STOCK", s.LowStockCount.ToString());

                dgvRecent.DataSource = new BindingList<SaleSummaryModel>(
                    _controller.GetTodaySales(cashierId));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the dashboard: " + ex.Message, "Dashboard");
            }
        }

        // each card shows a title on the first line and the number below it
        private static void SetCard(Label card, string title, string value) =>
            card.Text = title + Environment.NewLine + value;

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