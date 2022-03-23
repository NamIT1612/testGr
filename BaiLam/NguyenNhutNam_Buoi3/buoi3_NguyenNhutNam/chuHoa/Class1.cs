using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuHoa
{
    public class Class1:TextBox
    {
       public Class1()
        {
            this.KeyPress += Class1_KeyPress;
        }

        void Class1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
