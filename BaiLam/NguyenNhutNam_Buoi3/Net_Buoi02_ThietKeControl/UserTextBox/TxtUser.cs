using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserTextBox
{
    public class TxtUser:TextBox
    {
        public TxtUser()
        {
            this.Leave+=TxtUser_Leave;
        }

        void TxtUser_Leave(object sender, EventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            foreach (var c in this.Text)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    error.SetError(this, "Chuỗi không được chứa ký tự đặc biệt");
                }
            }
            
        }
    }
}
