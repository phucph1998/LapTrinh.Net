using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaClassLibrary;
using DevExpress.XtraEditors;

namespace SpaManagementSoftware
{
    public partial class frmAddTypeCus : Form
    {
        CustomerManager pCus;
        public frmAddTypeCus()
        {
            InitializeComponent();
            pCus = new CustomerManager();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txt_NameGroup.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Tên nhóm không được để trống");
                txt_NameGroup.Focus();
                return;
            }
            if (pCus.IsGroupCustomer(txt_NameGroup.Text) == false)
            {
                XtraMessageBox.Show("Đã tồn tại nhóm khách hàng này !");
            }
            else
            {
                if (pCus.InsertGroupCustomer(txt_NameGroup.Text))
                {
                    XtraMessageBox.Show("Thêm Nhóm Khách Hàng Thành Công !");

                }
                else
                {
                    XtraMessageBox.Show("Thêm Thất Bại !");
                }
            }
        }
    }
}
