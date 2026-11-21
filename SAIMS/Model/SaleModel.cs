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
        public decimal VatRate { get; set; }
        public decimal VatAmount { get; set; }
        public string DiscountType { get; set; } = "None";
        public string PaymentMethod { get; set; } = "Cash";
        public List<SaleItemModel> Items { get; set; } = new();
    }
}