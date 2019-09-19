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
        UserManager Config = new UserManager();
        private bool flag;
        private string nameAccount;//Giữ giá trị tên tài khoản gửi qua frmLogin
        private int numberRole;//Giữ giá trị quyền gửi qua frmLogin

        public string NameAccount
        {
            get { return nameAccount; }
            set { nameAccount = value; }
        }

        public int NumberRole
        {
            get { return numberRole; }
            set { numberRole = value; }
        }

        public bool Flag
        {
            get { return flag; }
            set { flag = value; }
        }
        public LoginUserControl()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text.Trim()))
            {
                XtraMessageBox.Show("Không được bỏ trống " + lbl_UserName.Text.ToLower());
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
            if (checkConn == 0)
            {
                ProcessLogin();//Cho phép đăng nhập
            }
            frmConfig config = new frmConfig();
            if (checkConn == 1)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không tồn tại", "Thông báo");
                config.ShowDialog();
            }
            if (checkConn == 2)
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
            if (result == 1)
            {
                XtraMessageBox.Show("Sai Tên Người Dùng hoặc Mật Khẩu !", "Thông Báo");
                return;
            }
            else if (result == 2)
            {
                XtraMessageBox.Show("Tài Khoản Đã Bị Khóa !", "Thông Báo");
                return;
            }
            XtraMessageBox.Show("Đăng Nhập Thành Công !", "Thông Báo");
            //xử lý form parent để gọi formMain
            flag = true;//Đánh dấu lại là Người dùng đã đăng nhập thành công và cho phép sử dụng frmMain
            nameAccount = txt_UserName.Text;
            numberRole = Config.GetNumberRole(txt_UserName.Text, txt_Password.Text);
            ParentForm.Close();//Đóng lại cửa sổ đăng nhập khi đã đăng nhập thành công
            //Bước tiếp: Sẽ có thêm các biến Lấy giá trị UserName, Pass, Quyền của người dùng gửi đến frmLogin -> frmMain
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsUpper(e.KeyChar))
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
