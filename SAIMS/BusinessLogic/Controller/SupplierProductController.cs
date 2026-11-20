using Microsoft.Data.SqlClient;
using SAIMS.BusinessLogic.Repository;
using SAIMS.Model;

namespace SAIMS.BusinessLogic
{
    public class SupplierProductController
    {
        private readonly SupplierProductRepository _repo = new();

        public List<CategoryModel> GetCategories() => _repo.GetCategories();

        public List<SupplierProductModel> GetBySupplier(int supplierId, string? search = null) =>
            _repo.GetBySupplier(supplierId, search);

        // Returns null when saved, otherwise the error message.
        // The category comes in as text (p.CategoryName). It is reused if it exists, otherwise created.
        public string? Save(SupplierProductModel p)
        {
            p.ItemName = p.ItemName.Trim();
            p.CategoryName = p.CategoryName.Trim();

            if (p.SupplierID == 0) return "Please select a supplier first.";
            if (p.ItemName == "") return "Item name is required.";
            if (p.CategoryName == "") return "Category is required. Choose one or type a new one.";
            if (p.CategoryName.Length > 100)
                return "Category name is too long (max 100 characters).";
            if (p.UnitPrice <= 0) return "Unit cost must be greater than 0.";
            if (p.Stock < 0) return "Supplier stock cannot be negative.";

            if (_repo.Exists(p.SupplierID, p.ItemName, p.SupplierProductID))
                return "This supplier already has an item with that name.";

            // only after every check passed, so a failed save never creates a category
            p.CategoryID = _repo.GetOrCreateCategory(p.CategoryName);

            if (p.SupplierProductID == 0) _repo.Add(p);
            else _repo.Update(p);
            return null;
        }

        public string Delete(int id)
        {
            try
            {
                return _repo.Delete(id) ? "Item deleted." : "Item not found.";
            }
            catch (SqlException ex) when (ex.Number == 547)   // foreign key conflict
            {
                return "Cannot delete: this item is already used by a store product.";
            }
        }
    }
}