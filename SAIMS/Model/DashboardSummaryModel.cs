namespace SAIMS.Model
{
    public class DashboardSummaryModel
    {
        public int ActiveSuppliers { get; set; }
        public int ProductsInStore { get; set; }
        public int LowStockCount { get; set; }
        public decimal InventoryValue { get; set; }
    }
}