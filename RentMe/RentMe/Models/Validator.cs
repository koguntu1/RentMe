using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentMe.Models
{
    class Validator
    {
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    textBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }

        public static bool IsPhoneNumber(MaskedTextBox textBox)
        {
            string phoneChars = textBox.Text.Replace(".", "").Replace("(", "").Replace("_", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            try
            {
                Convert.ToInt64(phoneChars);
                return true;
            }
            catch (FormatException)
            {
                textBox.Focus();
                return false;
            }
        }
    }
}
