using SAIMS.BusinessLogic.Repository;
using SAIMS.Model;

namespace SAIMS.BusinessLogic
{
    public class SaleController
    {
        private readonly SaleRepository _repo = new();

        // Returns null when the sale is saved, otherwise the error message
        public string? Checkout(SaleModel sale, out int saleId)
        {
            saleId = 0;

            if (sale.CashierID <= 0) return "No cashier is logged in.";
            if (sale.Items.Count == 0) return "The cart is empty.";
            if (sale.Items.Any(i => i.Quantity <= 0))
                return "A cart item has an invalid quantity.";
            if (sale.Discount < 0) return "Discount cannot be negative.";

            // The totals are recomputed here, so the UI cannot send wrong numbers
            sale.Subtotal = sale.Items.Sum(i => i.UnitPrice * i.Quantity);
            if (sale.Discount > sale.Subtotal)
                return "Discount cannot be more than the subtotal.";

            sale.Discount = SaleCalculator.DiscountFor(sale.Subtotal, sale.DiscountType);
            sale.VatRate = SaleCalculator.VatRateFor(sale.DiscountType);
            var t = SaleCalculator.Compute(sale.Subtotal, sale.Discount, sale.VatRate);
            sale.VatAmount = t.Vat;
            sale.Total = t.Total;
            if (!PaymentTypes.IsCash(sale.PaymentMethod))
                sale.AmountPaid = sale.Total;
            if (sale.AmountPaid < sale.Total)
                return "Amount paid is less than the total.";
            sale.ChangeAmount = sale.AmountPaid - sale.Total;

            try
            {
                saleId = _repo.Add(sale);
                return null;
            }
            catch (InvalidOperationException ex) { return ex.Message; }
        }

        // =============== TRANSACTIONS ===============
        public List<SaleSummaryModel> GetTransactions(string? search = null) =>
            _repo.GetTransactions(search);

        public SaleModel? GetSale(int saleId) => _repo.GetSale(saleId);
    }
}