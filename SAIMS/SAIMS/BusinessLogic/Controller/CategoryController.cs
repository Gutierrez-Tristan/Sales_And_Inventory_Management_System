using System.Data;
using SAIMS.Model;
using Microsoft.Data.SqlClient;
using SAIMS.BusinessLogic.Repository;

namespace SAIMS.BusinessLogic.Controller
{
    public class CategoryController
    {
        private readonly CategoryRepository repo = new CategoryRepository();

        public DataTable GetCategories() => repo.GetAll();

        // Returns an error message, or null if saved
        public string AddCategory(string name)
        {
            name = name?.Trim();
            if (string.IsNullOrEmpty(name))
                return "Category name is required.";
            if (repo.Exists(name))
                return "That category already exists.";

            repo.Add(name);
            return null;
        }
        public string UpdateCategory(int id, string name)
        {
            name = name?.Trim();

            if (string.IsNullOrEmpty(name))
                return "Category name is required.";
            if (repo.Exists(name, id))
                return "That category already exists.";

            bool ok = repo.Update(new CategoryModel { Id = id, Name = name });
            return ok ? null : "Failed to update category.";
        }

        public string DeleteCategory(int id)
        {
            try
            {
                return repo.Delete(id) ? null : "Category not found.";
            }
            catch (SqlException ex) when (ex.Number == 547) // foreign key violation
            {
                return "This category is still used by products and can't be deleted.";
            }
        }
    }
}
