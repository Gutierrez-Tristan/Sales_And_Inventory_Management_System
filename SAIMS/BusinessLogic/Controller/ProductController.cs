using Microsoft.Data.SqlClient;
using SAIMS.BusinessLogic.Repository;
using SAIMS.Model;

namespace SAIMS.BusinessLogic
{
    public class ProductController
    {
        private readonly ProductRepository _repo = new();

        public List<ProductModel> GetForSale(string? search = null) => _repo.GetForSale(search);

        public List<ProductModel> GetAll(string? search = null) => _repo.GetAll(search);

        public bool IsInStore(int supplierProductId) => _repo.Exists(supplierProductId);
        // status: "All", "OK", "Low" or "Out of stock"
        public List<ProductModel> GetInventory(string? search = null, string status = "All")
        {
            var list = _repo.GetInventory(search);
            if (status != "All")
                list = list.Where(p => p.StockStatus == status).ToList();
            return list;
        }

        // Returns null when saved, otherwise the error message
        public string? Add(ProductModel p, int openingStock)
        {
            if (p.SupplierProductID == 0) return "Please select a supplier item first.";
            if (p.CostPrice <= 0) return "Cost price must be greater than 0.";
            if (p.SellingPrice <= 0) return "Selling price must be greater than 0.";
            if (p.SellingPrice < p.CostPrice)
                return "Selling price cannot be lower than the cost price.";
            if (openingStock < 0) return "Opening stock cannot be negative.";
            if (p.ReorderLevel < 0) return "Reorder level cannot be negative.";

            try
            {
                if (_repo.Exists(p.SupplierProductID))
                    return "This item is already in the store. Use Restock instead.";

                _repo.AddWithOpeningStock(p, openingStock);
                return null;
            }
            catch (InvalidOperationException ex) { return ex.Message; }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                return "This item is already in the store. Use Restock instead.";
            }
        }

        // Returns null when saved, otherwise the error message
        public string? Restock(int productId, int qty, decimal costPerUnit)
        {
            if (productId == 0) return "Please choose a product to restock.";
            if (qty <= 0) return "Quantity to buy must be greater than 0.";
            if (costPerUnit <= 0) return "Cost per unit must be greater than 0.";

            try
            {
                _repo.Restock(productId, qty, costPerUnit);
                return null;
            }
            catch (InvalidOperationException ex) { return ex.Message; }
        }
    }
}