using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using SAIMS.Model;

namespace SAIMS.UI
{
    // Draws and previews a receipt. Used by the POS (after checkout)
    // and by the Transaction form (View Receipt / reprint).
    internal static class ReceiptPrinter
    {
        // ---- edit these for your store ----
        private const string StoreName = "INVEXA";
        private const string StoreTagline = "Sales and Inventory System";
        private const string StoreAddress = "123 Sample Street, City";
        private const string StoreContact = "Tel: 0900 000 0000";
        private const float LogoHeight = 80;        // printed logo height (1/100 inch)
        private const bool LogoGrayscale = false;   // true = grey logo (best for thermal printers)
        private const bool ThermalPaper = true;     // true = 80 mm roll, false = normal A4/Letter
        private const float ReceiptWidth = 315;     // 80 mm in 1/100 inch

        public static void ShowPreview(IWin32Window owner, SaleModel sale, int saleId,
                                       DateTime date, string cashier)
        {
            try
            {
                var doc = new PrintDocument();

                if (ThermalPaper)
                {
                    // 80 mm roll. Height fits the content.
                    int height = (int)Draw(null, sale, saleId, date, cashier) + 20;
                    doc.DefaultPageSettings.PaperSize = new PaperSize("Receipt80mm", (int)ReceiptWidth, height);
                    doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                }

                doc.PrintPage += (s, ev) =>
                {
                    var g = ev.Graphics!;

                    // Center the receipt on whatever paper the printer really uses
                    float x = (ev.PageBounds.Width - ReceiptWidth) / 2f - ev.PageSettings.HardMarginX;
                    g.TranslateTransform(Math.Max(x, 0), 0);

                    Draw(g, sale, saleId, date, cashier);
                    ev.HasMorePages = false;
                };

                using var preview = new PrintPreviewDialog
                {
                    Document = doc,
                    UseAntiAlias = true,
                    WindowState = FormWindowState.Maximized,
                    StartPosition = FormStartPosition.CenterScreen,
                    Text = "Print preview"
                };
                preview.ShowDialog(owner);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not show the receipt: " + ex.Message, "Print");
            }
        }

        // Draws the receipt. Pass g = null to only measure it. Returns the final height.
        // Units are 1/100 inch, which is what printers use.
        private static float Draw(Graphics? g, SaleModel sale, int saleId, DateTime date, string cashier)
        {
            // Work the totals out here so a rebuilt (reprinted) sale needs only items, discount and payment
            decimal subtotal = sale.Items.Sum(i => i.UnitPrice * i.Quantity);
            decimal total = Math.Max(subtotal - sale.Discount, 0);
            decimal change = Math.Max(sale.AmountPaid - total, 0);

            const float L = 10, CW = 295;   // left margin, content width
            float y = 10;

            using var fBody = new Font("Consolas", 8);
            using var fBold = new Font("Consolas", 8, FontStyle.Bold);
            using var fSmall = new Font("Consolas", 7);
            using var fTitle = new Font("Consolas", 14, FontStyle.Bold);
            using var fTotal = new Font("Consolas", 11, FontStyle.Bold);

            void Put(string s, Font f, StringAlignment a, float h,
                     float x = L, float w = CW, Brush? b = null)
            {
                if (g == null) return;
                using var sf = new StringFormat
                {
                    Alignment = a,
                    Trimming = StringTrimming.EllipsisCharacter,
                    FormatFlags = StringFormatFlags.NoWrap
                };
                g.DrawString(s, f, b ?? Brushes.Black, new RectangleF(x, y, w, h), sf);
            }

            void Center(string s, Font f, float h) { Put(s, f, StringAlignment.Center, h); y += h; }

            void Pair(string left, string right, Font f, float h = 14)
            {
                Put(left, f, StringAlignment.Near, h);
                Put(right, f, StringAlignment.Far, h);
                y += h;
            }

            void Dash()
            {
                if (g != null)
                {
                    using var pen = new Pen(Color.Black) { DashStyle = DashStyle.Dash };
                    g.DrawLine(pen, L, y + 4, L + CW, y + 4);
                }
                y += 10;
            }

            // ----- header with logo (Resources/ddd.png) -----
            using (var logo = Properties.Resources.ddd)
            {
                if (logo != null)
                {
                    float logoW = LogoHeight * logo.Width / logo.Height;   // keep the proportions
                    if (g != null)
                    {
                        var dest = new Rectangle((int)((ReceiptWidth - logoW) / 2f), (int)y,
                                                 (int)logoW, (int)LogoHeight);
                        using var attrs = new ImageAttributes();
                        if (LogoGrayscale)
                        {
                            attrs.SetColorMatrix(new ColorMatrix(new[]
                            {
                                new[] { 0.30f, 0.30f, 0.30f, 0f, 0f },
                                new[] { 0.59f, 0.59f, 0.59f, 0f, 0f },
                                new[] { 0.11f, 0.11f, 0.11f, 0f, 0f },
                                new[] { 0f,    0f,    0f,    1f, 0f },
                                new[] { 0f,    0f,    0f,    0f, 1f }
                            }));
                        }
                        g.DrawImage(logo, dest, 0, 0, logo.Width, logo.Height, GraphicsUnit.Pixel, attrs);
                    }
                    y += LogoHeight + 6;
                }
            }

            Center(StoreName, fTitle, 26);
            Center(StoreTagline, fSmall, 12);
            Center(StoreAddress, fSmall, 12);
            Center(StoreContact, fSmall, 12);
            Dash();

            // ----- sale info -----
            Pair("Sale #", saleId.ToString(), fBody);
            Pair("Date", date.ToString("dd/MM/yyyy hh:mm tt"), fBody);
            Pair("Cashier", cashier, fBody);
            Dash();

            // ----- items -----
            Put("ITEM", fBold, StringAlignment.Near, 14, L, 165);
            Put("QTY", fBold, StringAlignment.Center, 14, 175, 40);
            Put("AMOUNT", fBold, StringAlignment.Far, 14, 215, 90);
            y += 16;

            foreach (var i in sale.Items)
            {
                Put(i.ItemName, fBody, StringAlignment.Near, 14, L, 165);
                Put(i.Quantity.ToString(), fBody, StringAlignment.Center, 14, 175, 40);
                Put((i.UnitPrice * i.Quantity).ToString("N2"), fBody, StringAlignment.Far, 14, 215, 90);
                y += 14;

                if (i.Quantity > 1)
                {
                    Put($"  @ {i.UnitPrice:N2}", fSmall, StringAlignment.Near, 12, L, CW, Brushes.Gray);
                    y += 12;
                }
            }
            Dash();

            // ----- totals -----
            Pair("Subtotal", subtotal.ToString("N2"), fBody);
            Pair("Discount", sale.Discount > 0 ? "-" + sale.Discount.ToString("N2") : "0.00", fBody);
            Pair("TOTAL", total.ToString("N2"), fTotal, 22);
            Pair("Amount Paid", sale.AmountPaid.ToString("N2"), fBody);
            Pair("Change", change.ToString("N2"), fBody);
            Dash();

            // ----- footer -----
            Center("Thank you for shopping!", fBold, 16);
            Center("Please come again", fSmall, 12);

            return y;
        }
    }
}