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
using System.Runtime.InteropServices.WindowsRuntime;

namespace SpaClassLibrary
{
    public partial class LoginUserControl : UserControl
    {
        UserManager Config = new UserManager();
        public LoginUserControl()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_UserName.Text.Trim()))
            {
                XtraMessageBox.Show("Không được bỏ trống "+lbl_UserName.Text.ToLower());
                this.txt_UserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_Password.Text.Trim()))
            {
                XtraMessageBox.Show("Không được bỏ trống " + lbl_Password.Text.ToLower());
                this.txt_Password.Focus();
                return;
            }
            int checkConn = Config.Check_Config();
            if(checkConn == 0)
            {
                ProcessLogin();
            }
            frmConfig config = new frmConfig();
            if(checkConn == 1)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không tồn tại","Thông báo");                
                config.ShowDialog();
            }
            if(checkConn == 2)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không phù hợp", "Thông báo");
                //Xử lý cấu hình
                config.ShowDialog();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                ParentForm.Close();
        }

        public void ProcessLogin()
        {
            int result = Config.Check_User(txt_UserName.Text, txt_Password.Text);
            if(result==1)
            {
                XtraMessageBox.Show("Sai Tên Người Dùng hoặc Mật Khẩu !", "Thông Báo");
                return;
            }
            else if(result == 2)
            {
                XtraMessageBox.Show("Tài Khoản Đã Bị Khóa !", "Thông Báo");
                return;
            }
            XtraMessageBox.Show("Đăng Nhập Thành Công !", "Thông Báo");
            //xử lý form parent để gọi formMain
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar) || char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
