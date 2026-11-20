namespace SAIMS.Model
{
    public class SaleModel
    {
        public int SaleID { get; set; }
        public int CashierID { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ChangeAmount { get; set; }
        public List<SaleItemModel> Items { get; set; } = new();
    }
}