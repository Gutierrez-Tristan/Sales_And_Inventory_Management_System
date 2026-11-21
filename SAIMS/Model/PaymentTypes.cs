namespace SAIMS.Model
{
    public static class PaymentTypes
    {
        // Edit this list to match the payment modes your store accepts
        public static readonly string[] All = { "Cash", "GCash", "Card" };

        public static bool IsCash(string? method) =>
            string.IsNullOrWhiteSpace(method) || method == "Cash";
    }
}