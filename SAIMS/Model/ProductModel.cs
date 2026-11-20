namespace SAIMS.Model
{
    public class ProductModel
    {
        public int ProductID { get; set; }
        public int SupplierProductID { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; } = "";
        public string ItemName { get; set; } = "";
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; } = "";
        public decimal CostPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int Stock { get; set; }                  // store stock
        public int ReorderLevel { get; set; }
        public int SupplierStock { get; set; }          // display only
        public decimal SupplierUnitPrice { get; set; }  // supplier's current unit cost

        public string StockStatus =>
            Stock <= 0 ? "Out of stock" :
            Stock <= ReorderLevel ? "Low" : "OK";
    }
}