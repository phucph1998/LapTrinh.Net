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
    public partial class frmAddUserToGroup : DevExpress.XtraEditors.XtraForm
    {
        C_Role usr;
        public frmAddUserToGroup()
        {
            InitializeComponent();
            usr = new C_Role();
        }

        private void frmAddUserToGroup_Load(object sender, EventArgs e)
        {
            dGV_UsGroupUs.DataSource = usr.LoadTableUsGroupUs();
            dGV_User.DataSource = usr.LoadTableUser();
            cbb_NameGroup.DataSource = usr.LoadNameGroupUser();
            cbb_NameGroup.ValueMember = "ID";
            cbb_NameGroup.DisplayMember = "NAME_GROUP_USER";
        }

        public void LoadUserGroup(int pID)
        {
            try
            {
                dGV_UsGroupUs.DataSource = usr.LoadTableUsGroupUs_ID(pID);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString());
            }
        }

        private void btn_Grand_Click(object sender, EventArgs e)
        {
            if (dGV_User.CurrentRow != null)
            {
                string username = dGV_User.CurrentRow.Cells[0].Value.ToString();
                string idgroup = cbb_NameGroup.SelectedValue.ToString();
                bool flag = usr.InsertUserToGroup(username, idgroup);
                if (flag)
                {
                    XtraMessageBox.Show("Thêm Thành Công !");
                    LoadUserGroup(Convert.ToInt32(idgroup));
                }
                else
                {
                    XtraMessageBox.Show("Thêm Thất Bại !");
                }
            }
        }

        private void btn_DeleteGrand_Click(object sender, EventArgs e)
        {
            if (dGV_UsGroupUs.CurrentRow != null)
            {
                string username = dGV_UsGroupUs.CurrentRow.Cells[0].Value.ToString();
                string idgroup = dGV_UsGroupUs.CurrentRow.Cells[1].Value.ToString();
                bool flag = usr.DeleteUserOutGroup(username, idgroup);
                if (flag)
                {
                    XtraMessageBox.Show("Xóa thành công !");
                    LoadUserGroup(Convert.ToInt32(idgroup));
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại !");
                }
            }
        }

        private void cbb_NameGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbb_NameGroup.SelectedValue.ToString().Trim() != string.Empty)
                {
                    int id = Int32.Parse(cbb_NameGroup.SelectedValue.ToString());
                    LoadUserGroup(id);
                }

            }
            catch
            {
                return;
            }
        }
    }
}