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
    public partial class frmAddGroupSupplier : DevExpress.XtraEditors.XtraForm
    {
        C_Supplier _sup;
        public frmAddGroupSupplier()
        {
            InitializeComponent();
            _sup = new C_Supplier();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_NameGroup.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Tên nhóm không được để trống!");
                txt_NameGroup.Focus();
                return;
            }
            if (_sup.IsGroupSupplierMySQL(txt_NameGroup.Text) == false)
            {
                XtraMessageBox.Show("Đã tồn tại nhóm khách hàng này !");
            }
            else
            {
                if (_sup.InsertGroupSupplierMySQL(txt_NameGroup.Text))
                {
                    XtraMessageBox.Show("Thêm Nhóm Khách Hàng Thành Công !");

                }
                else
                {
                    XtraMessageBox.Show("Thêm Thất Bại !");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}