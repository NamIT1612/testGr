using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mailTextBox
{
    public class mailTextBox:TextBox
    {
        public mailTextBox()
        {
            this.Leave += TxtMail_Leave;
        }

        void TxtMail_Leave(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            
            bool kt1 = this.Text.ToLower().Contains("@"), kt2 = this.Text.ToLower().Contains(".com");
            if (kt1 && kt2)
            {
                error.Clear();
            }
            else
            {
                error.SetError(this, "Email không đúng định dạng");
                
            }
            
        }
    }
}
