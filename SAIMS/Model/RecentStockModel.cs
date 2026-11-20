namespace SAIMS.Model
{
    public class RecentStockModel
    {
        public DateTime PurchaseDate { get; set; }
        public string ItemName { get; set; } = "";
        public int Quantity { get; set; }
    }
}