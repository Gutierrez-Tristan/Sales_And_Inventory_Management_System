using System.Net.Mail;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;
using SAIMS.BusinessLogic.Repository;
using SAIMS.Model;

namespace SAIMS.BusinessLogic
{
    public class SupplierController
    {
        private readonly SupplierRepository _repo = new();

        public List<SupplierModel> GetAll(string? search = null) => _repo.GetAll(search);

        // Returns null when saved, otherwise the error message
        public string? Save(SupplierModel s)
        {
            s.Name = s.Name.Trim();
            s.Email = s.Email.Trim();
            s.Phone = s.Phone.Trim();
            s.Address = s.Address.Trim();

            if (s.Name == "") return "Supplier name is required.";
            if (s.Email == "") return "Email is required.";
            if (!IsValidEmail(s.Email)) return "Email format is invalid.";
            if (s.Phone == "") return "Phone is required.";
            if (!Regex.IsMatch(s.Phone, @"^[0-9+\-\s]{7,15}$"))
                return "Phone must be 7 to 15 digits.";
            if (s.Address == "") return "Address is required.";

            try
            {
                if (s.SupplierID == 0)
                {
                    if (_repo.Exists(s.Email)) return "A supplier with this email already exists.";
                    _repo.Add(s);
                }
                else
                {
                    if (_repo.Exists(s.Email, s.SupplierID))
                        return "Another supplier already uses this email.";
                    _repo.Update(s);
                }
                return null;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                return "A supplier with this name already exists.";
            }
        }

        // Deletes the supplier, or deactivates it if it has products
        public string Remove(int id)
        {
            if (_repo.HasProducts(id))
            {
                _repo.Deactivate(id);
                return "This supplier has products, so it was set to Inactive instead of deleted.";
            }
            _repo.Delete(id);
            return "Supplier deleted.";
        }

        private static bool IsValidEmail(string email)
        {
            try { return new MailAddress(email).Address == email; }
            catch { return false; }
        }
    }
}