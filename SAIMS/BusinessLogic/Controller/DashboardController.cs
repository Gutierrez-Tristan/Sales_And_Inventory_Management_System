using SAIMS.BusinessLogic.Repository;
using SAIMS.Model;

namespace SAIMS.BusinessLogic
{
    public class DashboardController
    {
        private readonly DashboardRepository _repo = new();
        public CashierSummaryModel GetCashierSummary(int cashierId) => _repo.GetCashierSummary(cashierId);
        public List<SaleSummaryModel> GetTodaySales(int cashierId, int top = 10) =>
            _repo.GetTodaySales(cashierId, top);
        public DashboardSummaryModel GetSummary() => _repo.GetSummary();
        public List<ProductModel> GetLowStock(int top = 3) => _repo.GetLowStock(top);
        public List<RecentStockModel> GetRecentStocks(int top = 3) => _repo.GetRecentStocks(top);
    }
}