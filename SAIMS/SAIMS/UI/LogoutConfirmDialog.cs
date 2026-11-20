namespace SAIMS.UI
{
    public class LogoutConfirmDialog : Form
    {
        public LogoutConfirmDialog()
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            BackColor = Color.OrangeRed;                // the orange border, like your other popups
            Padding = new Padding(8);
            ClientSize = new Size(380, 200);

            var inner = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };

            var lblTitle = new Label
            {
                Text = "LOGOUT",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Left = 0,
                Top = 20,
                Width = 364,
                Height = 40
            };

            var lblMessage = new Label
            {
                Text = "Are you sure you want to logout?",
                Font = new Font("Segoe UI", 11),
                TextAlign = ContentAlignment.MiddleCenter,
                Left = 0,
                Top = 70,
                Width = 364,
                Height = 40
            };

            var btnYes = new Button
            {
                Text = "Yes",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.LightGreen,
                DialogResult = DialogResult.Yes,
                Left = 50,
                Top = 130,
                Width = 120,
                Height = 38
            };

            var btnNo = new Button
            {
                Text = "No",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.LightCoral,
                DialogResult = DialogResult.No,
                Left = 194,
                Top = 130,
                Width = 120,
                Height = 38
            };

            inner.Controls.AddRange(new Control[] { lblTitle, lblMessage, btnYes, btnNo });
            Controls.Add(inner);

            AcceptButton = btnYes;      // Enter = Yes
            CancelButton = btnNo;       // Esc = No
        }
    }
}