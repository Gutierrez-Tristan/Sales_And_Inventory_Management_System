namespace SAIMS.Model
{
    public class CashierSummaryModel
    {
        public decimal SalesToday { get; set; }
        public int TransactionsToday { get; set; }
        public int ItemsSold { get; set; }
        public int LowStockCount { get; set; }
    }
}