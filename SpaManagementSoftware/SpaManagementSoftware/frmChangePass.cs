using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpaClassLibrary;

namespace SpaManagementSoftware
{
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        UserManager usr;
        C_Account acc;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public frmChangePass()
        {
            InitializeComponent();
            usr = new UserManager();
            acc = new C_Account();
        }

        private void btn_Agree_Click(object sender, EventArgs e)
        {
            //B1 Lấy pass từ SQL so sánh với pass từ txt_PassOld
            //B2 MD5 pass trước khi cập nhật
            if (txt_PassOld.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ !");
                txt_PassOld.Focus();
                return;
            }
            if (txt_PassNew.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu mới !");
                txt_PassNew.Focus();
                return;
            }
            if (txt_ConfirmPass.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Chưa xác nhận mật khẩu !");
                txt_ConfirmPass.Focus();
                return;
            }
            if (string.Equals(usr.EncodePass(txt_PassNew.Text), usr.EncodePass(txt_ConfirmPass.Text)))
            {
                //Thực hiện cho cập nhật mật khẩu
                if (acc.ChangePassMySQL(this.UserName, txt_PassNew.Text, txt_PassOld.Text))
                {
                    XtraMessageBox.Show("Đổi mật khẩu thành công !");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Không thành công");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}