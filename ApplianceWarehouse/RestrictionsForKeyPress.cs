using System;
using System.Windows.Forms;

namespace ApplianceWarehouse
{
    internal class RestrictionsForKeyPress
    {
        public void RestrictSymbols(KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        public void RestrictAnything(KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
