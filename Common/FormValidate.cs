using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT
{
    public class FormValidate
    {
        public static void ValidateInputNumber(object sender, KeyPressEventArgs e)
        {
            var textbox = sender as TextBox;

            if (textbox != null)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                
                // only allow one decimal point
                if ((e.KeyChar == '.') && (textbox.Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

        }
    }
}
