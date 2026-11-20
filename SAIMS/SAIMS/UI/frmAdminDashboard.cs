using SAIMS.BusinessLogic;

namespace SAIMS.UI
{
    public partial class frmAdminDashboard : Form
    {
        private readonly DashboardController _controller = new();
        private const int Rows = 3;      // rows shown in each table

        public frmAdminDashboard()
        {
            InitializeComponent();

            LoadDashboard();

            btnRestock.Click += btnRestock_Click;
            Activated += (s, e) => LoadDashboard();    // refresh when you come back to this screen
        }

        // =============== LOAD EVERYTHING ===============
        private void LoadDashboard()
        {
            try
            {
                // ----- cards -----
                var summary = _controller.GetSummary();
                lblSuppliersCount.Text = summary.ActiveSuppliers.ToString();
                lblProductsCount.Text = summary.ProductsInStore.ToString();
                lblLowStockCount.Text = summary.LowStockCount.ToString();
                lblInventoryValue.Text = summary.InventoryValue.ToString("N0");

                // ----- low stock alerts -----
                var low = _controller.GetLowStock(Rows);
                for (int i = 1; i <= Rows; i++)
                {
                    var p = i <= low.Count ? low[i - 1] : null;
                    Lbl($"lblLowProduct{i}").Text = p?.ItemName ?? "";
                    Lbl($"lblLowStock{i}").Text = p?.Stock.ToString() ?? "";
                    Lbl($"lblLowReorder{i}").Text = p?.ReorderLevel.ToString() ?? "";
                }
                if (low.Count == 0)
                    Lbl("lblLowProduct1").Text = "All products are stocked";
                btnRestock.Enabled = low.Count > 0;

                // ----- recent stocks -----
                var recent = _controller.GetRecentStocks(Rows);
                for (int i = 1; i <= Rows; i++)
                {
                    var s = i <= recent.Count ? recent[i - 1] : null;
                    Lbl($"lblRecentDate{i}").Text = s?.PurchaseDate.ToString("dd/MM/yy") ?? "";
                    Lbl($"lblRecentItem{i}").Text = s?.ItemName ?? "";
                    Lbl($"lblRecentQty{i}").Text = s?.Quantity.ToString() ?? "";
                }
                if (recent.Count == 0)
                    Lbl("lblRecentItem1").Text = "No restocks yet";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load the dashboard: " + ex.Message, "Dashboard");
            }
        }

        // finds a label by name, so we can fill rows in a loop
        private Label Lbl(string name) => (Label)Controls.Find(name, true)[0];

        // =============== RESTOCK BUTTON ===============
        private void btnRestock_Click(object? sender, EventArgs e)
        {
            frmProductManagement productManagement = new frmProductManagement();
            productManagement.Show();
            this.Hide();
        }
        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            frmSuppliers supplierModule = new frmSuppliers();
            supplierModule.Show();
            this.Hide();
        }

        private void btnSupplierProduct_Click(object sender, EventArgs e)
        {
            frmSupplierProduct supplierProduct = new frmSupplierProduct();
            supplierProduct.Show();
            this.Hide();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
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