namespace SAIMS.Model
{
    public static class SaleCalculator
    {
        public const decimal DefaultVatRate = 0.12m;
        public const decimal SeniorPwdRate = 0.20m;

        public static readonly string[] DiscountTypes = { "None", "Senior Citizen", "PWD" };

        // Senior Citizen and PWD purchases are VAT-exempt
        public static bool IsVatExempt(string? type) => type == "Senior Citizen" || type == "PWD";

        public static decimal VatRateFor(string? type) => IsVatExempt(type) ? 0m : DefaultVatRate;

        public static decimal DiscountFor(decimal subtotal, string? type) =>
            IsVatExempt(type)
                ? Math.Round(subtotal * SeniorPwdRate, 2, MidpointRounding.AwayFromZero)
                : 0m;

        // Total = (Subtotal - Discount) + VAT
        public static (decimal Vat, decimal Total) Compute(decimal subtotal, decimal discount, decimal vatRate)
        {
            decimal taxable = Math.Max(subtotal - discount, 0);
            decimal vat = Math.Round(taxable * vatRate, 2, MidpointRounding.AwayFromZero);
            return (vat, taxable + vat);
        }
    }
}