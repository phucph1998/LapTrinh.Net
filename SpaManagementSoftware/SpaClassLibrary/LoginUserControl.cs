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
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace SpaClassLibrary
{
    public partial class LoginUserControl : UserControl
    {
        UserManager Config = new UserManager();
        private bool flag;
        private string nameAccount;//Giữ giá trị tên tài khoản gửi qua frmLogin
        private int numberRole;//Giữ giá trị quyền gửi qua frmLogin
        public string nameDatabase;//Giữ giá trị tên cơ sở dữ liệu gửi qua frmLogin

        public string NameDatabase
        {
            get { return nameDatabase; }
            set { nameDatabase = value; }
        }

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
            //Kiểm tra dữ liệu đầu vào
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
            //Kiểm tra cấu hình trước khi đăng nhập
            int checkConn = Config.Check_Config();
            if (checkConn == 0)
            {
                ProcessLogin();//Cho phép đăng nhập
                Check_RememberPass();//Ghi nhớ mật khẩu
            }
            frmConfig config = new frmConfig();
            if (checkConn == 1)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không tồn tại", "Thông báo");
                config.ShowDialog();
                GetNameDatabase();
            }
            if (checkConn == 2)
            {
                XtraMessageBox.Show("Chuỗi cấu hình không phù hợp", "Thông báo");
                //Xử lý cấu hình
                config.ShowDialog();
                GetNameDatabase();
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                ParentForm.Close();
        }

        //Mã hóa mật khẩu MD5
        public string EncodePass(string pPass)
        {
            MD5 encode = MD5.Create();

            //Chuyển chuỗi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pPass);

            //Mã hóa chuỗi đã chuyển
            byte[] hash = encode.ComputeHash(inputBytes);

            //tạo đối tượng StringBuilder
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("x"));
            }
            return result.ToString();
        }

        //Kiểm tra checkbox ghi nhớ mật khẩu
        public void Check_RememberPass()
        {
            if (chk_RemeberPass.Checked)
            {
                Properties.Settings.Default.UserName = txt_UserName.Text;
                Properties.Settings.Default.PassWord = txt_Password.Text;
                Properties.Settings.Default.RemeberPass = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.PassWord = "";
                Properties.Settings.Default.RemeberPass = false;
                Properties.Settings.Default.Save();
            }
        }

        //Tiến trình đăng nhập
        public void ProcessLogin()
        {
            int result = Config.Check_User(txt_UserName.Text, EncodePass(txt_Password.Text));
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
            numberRole = Config.GetNumberRole(txt_UserName.Text, EncodePass(txt_Password.Text));
            ParentForm.BackColor = Color.White;
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

        private void LoginUserControl_Load(object sender, EventArgs e)
        {
            ParentForm.Show();
            if (Properties.Settings.Default.RemeberPass)
            {
                txt_UserName.Text = Properties.Settings.Default.UserName;
                txt_Password.Text = Properties.Settings.Default.PassWord;
                chk_RemeberPass.Checked = true;
            }
            GetNameDatabase();
        }

        public void GetNameDatabase()
        {
            SqlConnection temp = new SqlConnection(Properties.Settings.Default.DB_SPAConnect);
            nameDatabase = temp.Database.ToString();
            lbl_NameDatabase.Text = temp.Database.ToString();
        }
    }
}
