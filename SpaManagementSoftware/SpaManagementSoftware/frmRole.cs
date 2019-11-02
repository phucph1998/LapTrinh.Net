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
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        C_Role usr;
        public frmRole()
        {
            InitializeComponent();
            usr = new C_Role();
        }

        //private void gROUP_USERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.gROUP_USERBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dS_GRAND);

        //}

        private void frmRole_Load(object sender, EventArgs e)
        {
            dGV_GroupUser.DataSource = usr.LoadNameGroupUser();
            //Properties.Settings.Default["DB_SPAConnectionString"] = usr.GetStringConfig();
            //Properties.Settings.Default.Save();
            //// TODO: This line of code loads data into the 'dS_GRAND.GRANT_RIGHT' table. You can move, or remove it, as needed.
            //this.gRANT_RIGHTTableAdapter.Fill(this.dS_GRAND.GRANT_RIGHT);
            //// TODO: This line of code loads data into the 'dS_GRAND.GROUP_USER' table. You can move, or remove it, as needed.
            //this.gROUP_USERTableAdapter.Fill(this.dS_GRAND.GROUP_USER);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //ma nhom,ma man hinh, quyen 
                for (int i = 0; i < dGV_GrandRole.Rows.Count; i++)
                {
                    string role = dGV_GrandRole.Rows[i].Cells[2].Value.ToString();//Quyền
                    string idScreen = dGV_GrandRole.Rows[i].Cells[0].Value.ToString();//Mã màn hình
                    string idGroupUser = dGV_GroupUser.CurrentRow.Cells[0].Value.ToString();
                    //            //kiểm tra nếu quyền đã được cấp mà đã thu hồi thì Cập nhật lại quyền, ngược lại thì thêm vào.
                    if (usr.CheckGrandRight(idGroupUser, idScreen) != 0)
                    {
                        if (role == string.Empty)
                        {
                            role = "0";
                            usr.UpdateRole(idGroupUser, idScreen, role);
                        }
                        else
                        {
                            usr.UpdateRole(idGroupUser, idScreen, role);
                        }
                    }
                    else
                    {
                        usr.InsertRole(idGroupUser, idScreen, role);
                    }
                    //            //Lúc này chỉ có 2 TH : T/F
                }
                XtraMessageBox.Show("Đã Lưu !");
            }
            catch
            {
                XtraMessageBox.Show("Lưu Thất Bại!");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }

        private void dGV_GroupUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dGV_GroupUser.CurrentRow != null)
            {
                dGV_GrandRole.DataSource = usr.LoadTableScreenOfGroupUs(dGV_GroupUser.CurrentRow.Cells[0].Value.ToString());
            }
        }
    }
}