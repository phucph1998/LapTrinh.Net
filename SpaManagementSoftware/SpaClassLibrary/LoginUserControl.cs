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
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (lg.isAccount(txt_UserName.Text, txt_Password.Text))
            {
                XtraMessageBox.Show("Đăng nhập thành công", "Thông báo");
                this.FindForm();
            }
            else
            {
                XtraMessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
        }
    }
}
