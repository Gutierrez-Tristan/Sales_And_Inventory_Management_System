namespace SAIMS.Model
{
    // One row of the Transaction grid (a completed sale, without its items)
    public class SaleSummaryModel
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public int CashierID { get; set; }
        public string CashierName { get; set; } = "";
        public int ItemCount { get; set; }          // total units sold
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal ChangeAmount { get; set; }
    }
}