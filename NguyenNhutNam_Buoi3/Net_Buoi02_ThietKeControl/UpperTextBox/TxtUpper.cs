using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpperTextBox
{
    public class TxtUpper:TextBox
    {
        public TxtUpper()
        {
            this.KeyPress += TxtUpper_KeyPress;
        }

        void TxtUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
