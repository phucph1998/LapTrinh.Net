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
        UserManager usr;
        public frmAddUserToGroup()
        {
            InitializeComponent();
            usr = new UserManager();
        }

        //private void uSER_GROUP_USERDKBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.uSER_GROUP_USERDKBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dS_GRAND);

        //}

        private void frmAddUserToGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default["DB_SPAConnectionString"] = usr.GetStringConfig();
                Properties.Settings.Default.Save();
                // TODO: This line of code loads data into the 'dS_GRAND.USER_GROUP_USER' table. You can move, or remove it, as needed.
                this.uSER_GROUP_USERTableAdapter.Fill(this.dS_GRAND.USER_GROUP_USER);
                // TODO: This line of code loads data into the 'dS_GRAND.GROUP_USER' table. You can move, or remove it, as needed.
                this.gROUP_USERTableAdapter.Fill(this.dS_GRAND.GROUP_USER);
                // TODO: This line of code loads data into the 'dS_GRAND.ACCOUNT' table. You can move, or remove it, as needed.
                this.aCCOUNTTableAdapter.Fill(this.dS_GRAND.ACCOUNT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void LoadUserGroup()
        {
            try
            {
                this.uSER_GROUP_USERDKTableAdapter.Fill(this.dS_GRAND.USER_GROUP_USERDK, Int32.Parse(gROUP_USERComboBox.SelectedValue.ToString()));
            }
            catch
            {
                return;
            }
        }

        private void btn_Grand_Click(object sender, EventArgs e)
        {
            try
            {
                int? t = this.uSER_GROUP_USERTableAdapter.Insert(Int32.Parse(aCCOUNTDataGridView.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(gROUP_USERComboBox.SelectedValue.ToString()), 1);
                if (t == 1)
                {
                    XtraMessageBox.Show("Thêm người dùng vào nhóm thành công !");
                    LoadUserGroup();
                }
            }
            catch
            {
                XtraMessageBox.Show("Thêm thất bại, hoặc tài khoản đã tồn tại trong nhóm");
            }
        }

        private void gROUP_USERComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadUserGroup();
        }

        private void btn_DeleteGrand_Click(object sender, EventArgs e)
        {
            try
            {
                int? t = this.uSER_GROUP_USERTableAdapter.Delete(Int32.Parse(uSER_GROUP_USERDKDataGridView.CurrentRow.Cells[1].Value.ToString()), Int32.Parse(uSER_GROUP_USERDKDataGridView.CurrentRow.Cells[0].Value.ToString()), Int32.Parse(uSER_GROUP_USERDKDataGridView.CurrentRow.Cells[2].Value.ToString()));
                if (t == 1)
                {
                    XtraMessageBox.Show("Xóa người dùng khỏi nhóm thành công !");
                    LoadUserGroup();
                }
            }
            catch
            {

                XtraMessageBox.Show("Xóa người dùng khỏi nhóm thất bại !");
            }
        }
    }
}