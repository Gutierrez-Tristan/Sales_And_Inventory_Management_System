namespace SAIMS.Model
{
    public class SaleItemModel
    {
        public int ProductID { get; set; }
        public string ItemName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public decimal LineTotal => UnitPrice * Quantity;
    }
}