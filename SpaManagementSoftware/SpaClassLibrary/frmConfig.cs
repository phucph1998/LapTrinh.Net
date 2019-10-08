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

namespace SpaClassLibrary
{
    public partial class frmConfig : DevExpress.XtraEditors.XtraForm
    {
        UserManager Config = new UserManager();
        public frmConfig()
        {
            InitializeComponent();
        }

        private void cbb_ServerName_DropDown(object sender, EventArgs e)
        {
            DataTable dt = Config.GetServerName();
            cbb_Database.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cbb_ServerName.Items.Add(row[col]);
                }
            }
            //List<string> srvname = Config.LoadServerName();
            //cbb_ServerName.Items.Clear();
            //foreach (string item in srvname)
            //{
            //    cbb_ServerName.Items.Add(item);
            //}
        }

        private void cbb_Database_DropDown(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_Database.Items.Clear();
                List<string> list = Config.GetDatabaseName(cbb_ServerName.Text, txt_UserName.Text, txt_Password.Text);
                if (list == null)
                {
                    XtraMessageBox.Show("Thông tin cấu hình chưa chính xác", "Thông báo");
                    return;
                }
                foreach (string item in list)
                {
                    cbb_Database.Items.Add(item);
                }
            }
        }

        private bool CheckedBeforSearchNameDB()
        {
            if (cbb_ServerName.Text == string.Empty)
            {
                XtraMessageBox.Show("Server Name chưa được chọn hoặc nhập", "Thông Báo");
                return false;
            }
            if (txt_UserName.Text == string.Empty)
            {
                XtraMessageBox.Show("User Name chưa được nhập", "Thông Báo");
                return false;
            }
            if (txt_Password.Text == string.Empty)
            {
                XtraMessageBox.Show("Password chưa được nhập", "Thông Báo");
                return false;
            }
            return true;
        }

        private void btn_SaveConfig_Click(object sender, EventArgs e)
        {
            Config.ChangConnectionString(cbb_ServerName.Text, cbb_Database.Text, txt_UserName.Text, txt_Password.Text);
            LoginUserControl uc = new LoginUserControl();
            uc.nameDatabase = cbb_Database.Text;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) || char.IsUpper(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}