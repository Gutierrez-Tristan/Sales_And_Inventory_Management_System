namespace SAIMS.Model
{
    public class SupplierProductModel
    {
        public int SupplierProductID { get; set; }
        public int SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; } = "";   // display only
        public string ItemName { get; set; } = "";
        public decimal UnitPrice { get; set; }           // shown as "Unit Cost" in the UI
        public int Stock { get; set; }                   // the supplier's available stock
    }
}