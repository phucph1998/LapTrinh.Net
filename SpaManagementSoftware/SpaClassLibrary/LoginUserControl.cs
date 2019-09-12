using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpaClassLibrary
{
    public partial class LoginUserControl : UserControl
    {
        Account lg = new Account();
        public Boolean checkClose = new Boolean();
        public LoginUserControl()
        {
            InitializeComponent();
            checkClose = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (lg.isAccount(txt_UserName.Text, txt_Password.Text))
            {
                XtraMessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            checkClose = true;
        }
    }
}
