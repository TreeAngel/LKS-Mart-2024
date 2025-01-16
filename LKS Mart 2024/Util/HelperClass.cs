using LKS_Mart_2024.Util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LKS_Mart_2024.Helper
{
    public static class HelperClass
    {
        public static tbl_user userSession;

        public static bool ValidateValue(Control control)
        {
            bool isValid = true;
            isValid = (control.Controls.OfType<TextBox>().Where(x => String.IsNullOrEmpty(x.Text)).Count() == 0 &&
                control.Controls.OfType<ComboBox>().Where(x => x.SelectedIndex == -1).Count() == 0);
            return isValid;
        }

        public static void ClearValue(Control control)
        {
            foreach (var item in control.Controls.OfType<TextBox>())
            {
                item.Clear();
            }
            foreach (var item in control.Controls.OfType<ComboBox>())
            {
                item.SelectedIndex = -1;
            }
            foreach (var item in control.Controls.OfType<NumericUpDown>())
            {
                item.Value = 0;
            }
        }

        public static void TextBoxNumberOnly(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
