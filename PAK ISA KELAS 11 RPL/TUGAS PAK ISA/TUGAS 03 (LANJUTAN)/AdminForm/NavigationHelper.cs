using System.Windows.Forms;

namespace AdminForm
{
    /// <summary>
    /// Mencegah navigasi rantai ShowDialog "tersangkut" di form perantara.
    /// Sinyal: DialogResult.OK berarti kembali ke Dashboard (Master Bandara),
    /// DialogResult.Abort berarti logout (kembali ke LoginForm).
    /// </summary>
    public static class NavigationHelper
    {
        public static void Open(Form from, Form to)
        {
            from.Hide();
            DialogResult result = to.ShowDialog();
            if (result == DialogResult.Abort)
            {
                from.DialogResult = DialogResult.Abort;
                from.Close();
                return;
            }
            if (result == DialogResult.OK)
            {
                from.DialogResult = DialogResult.OK;
                from.Close();
                return;
            }
            from.Show();
        }

        public static void OpenFromDashboard(Form from, Form to)
        {
            from.Hide();
            DialogResult result = to.ShowDialog();
            if (result == DialogResult.Abort)
            {
                from.DialogResult = DialogResult.Abort;
                from.Close();
                return;
            }
            from.Show();
        }

        public static void BackToDashboard(Form form)
        {
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        public static void Logout(Form form)
        {
            form.DialogResult = DialogResult.Abort;
            form.Close();
        }
    }
}
