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
    public partial class frmAddGroupCus : DevExpress.XtraEditors.XtraForm
    {
        CustomerManager _cus;
        public frmAddGroupCus()
        {
            InitializeComponent();
            _cus = new CustomerManager();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_NameGroup.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Tên nhóm không được để trống");
                txt_NameGroup.Focus();
                return;
            }
            if (_cus.IsGroupCustomerMySQL(txt_NameGroup.Text) == false)
            {
                XtraMessageBox.Show("Đã tồn tại nhóm khách hàng này !");
            }
            else
            {
                if (_cus.InsertGroupCustomerMySQL(txt_NameGroup.Text))
                {
                    XtraMessageBox.Show("Thêm Nhóm Khách Hàng Thành Công !");
                    this.Close();

                }
                else
                {
                    XtraMessageBox.Show("Thêm Thất Bại !");
                    this.Close();
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}