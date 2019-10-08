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
        UserManager usr;
        public frmRole()
        {
            InitializeComponent();
            usr = new UserManager();
        }

        private void gROUP_USERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gROUP_USERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_GRAND);

        }

        private void frmRole_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default["DB_SPAConnectionString"] = usr.GetStringConfig();
            Properties.Settings.Default.Save();
            // TODO: This line of code loads data into the 'dS_GRAND.GRANT_RIGHT' table. You can move, or remove it, as needed.
            this.gRANT_RIGHTTableAdapter.Fill(this.dS_GRAND.GRANT_RIGHT);
            // TODO: This line of code loads data into the 'dS_GRAND.GROUP_USER' table. You can move, or remove it, as needed.
            this.gROUP_USERTableAdapter.Fill(this.dS_GRAND.GROUP_USER);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //ma nhom,ma man hinh, quyen 
                for (int i = 0; i < gRANT_RIGHTDKDataGridView.Rows.Count; i++)
                {
                    string t = gRANT_RIGHTDKDataGridView.Rows[i].Cells[2].Value.ToString();
                    string idScreen = gRANT_RIGHTDKDataGridView.Rows[i].Cells[0].Value.ToString();
                    if (t != string.Empty)
                    {
                        //kiểm tra nếu quyền đã được cấp mà đã thu hồi thì Cập nhật lại quyền, ngược lại thì thêm vào.
                        //Lúc này chỉ có 2 TH : T/F
                        if (this.gRANT_RIGHTTableAdapter.IsGrandRightScalarQuery(Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen) > 0)
                        {
                            //Cập nhật lại quyền
                            if (this.gRANT_RIGHTTableAdapter.GetRoleScalarQuery(Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen) != Boolean.Parse(t))
                            {
                                this.gRANT_RIGHTTableAdapter.Update(Boolean.Parse(t), Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen, this.gRANT_RIGHTTableAdapter.GetRoleScalarQuery(Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen));
                            }
                        }
                        else
                        {
                            //Thêm quyền, xóa quyền
                            if (t.Equals("True"))//Cấp quyền
                            {
                                this.gRANT_RIGHTTableAdapter.Insert(Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen, true);
                            }
                            else
                            {
                                this.gRANT_RIGHTTableAdapter.Insert(Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString()), idScreen, false);
                            }
                        }
                    }
                }
                XtraMessageBox.Show("Đã Lưu !");
            }
            catch
            {
                XtraMessageBox.Show("Lưu Thất Bại!");
            }
        }

        private void gROUP_USERDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Int32.Parse(gROUP_USERDataGridView.CurrentRow.Cells[0].Value.ToString());
                this.gRANT_RIGHTDKTableAdapter.Fill(this.dS_GRAND.GRANT_RIGHTDK, temp);
            }
            catch
            {
                return;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát !","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}