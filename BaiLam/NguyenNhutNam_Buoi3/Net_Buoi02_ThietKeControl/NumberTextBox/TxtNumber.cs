using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberTextBox
{
    public class TxtNumber:TextBox
    {
        public TxtNumber()
        {
            this.KeyPress += TxtNumber_KeyPress;
        }

        void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
