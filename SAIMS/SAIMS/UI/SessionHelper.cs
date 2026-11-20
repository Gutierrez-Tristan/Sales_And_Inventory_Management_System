using SAIMS.Model;

namespace SAIMS.UI
{
    public static class SessionHelper
    {
        // Call this from any form's Logout button
        public static void Logout(Form current)
        {
            using var dialog = new LogoutConfirmDialog();
            if (dialog.ShowDialog(current) != DialogResult.Yes) return;

            UserSession.Current = null;            // forget who was logged in

            // Reuse the login form that is already open (hidden), or make a new one
            var login = Application.OpenForms.OfType<frmLogin>().FirstOrDefault() ?? new frmLogin();
            login.Show();

            // Close every other screen. Hidden forms are still open in the background.
            foreach (var f in Application.OpenForms.Cast<Form>().Where(f => f != login).ToList())
                f.Close();
        }
    }
}