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
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerManager cus;
        public frmAddCustomer()
        {
            InitializeComponent();
            cus = new CustomerManager();
        }

        //Kiểm tra radioBtn Nam,Nu
        public string CheckSex(RadioButton pMen, RadioButton pWomen)
        {
            if (pMen.Checked)
            {
                return "Nam";
            }
            else
            {
                return "Nữ";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập số CMND");
                txt_ID.Focus();
                return;
            }
            if (txt_LName.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập Họ Khách Hàng");
                txt_LName.Focus();
                return;
            }
            if (txt_FName.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập Tên Khách Hàng");
                txt_FName.Focus();
                return;
            }
            if (txt_Phone.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập số SĐT khách hàng");
                txt_Phone.Focus();
                return;
            }
            if (txt_Address.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập Địa chỉ khách hàng");
                txt_Address.Focus();
                return;
            }
            if (cbb_TypeCus.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải chọn Loại Khách Hàng");
                cbb_TypeCus.Focus();
                return;
            }
            int add = cus.InsertCustomer(txt_ID.Text, txt_LName.Text, txt_FName.Text, CheckSex(rbtn_Men, rbtn_Women), txt_Phone.Text, txt_Address.Text, cbb_TypeCus.SelectedIndex + 1);
            if(add == 1)
            {
                XtraMessageBox.Show("Khách hàng đã tồn tại !");
                return;
            }
            else
            {
                if(add == 2)
                {
                    XtraMessageBox.Show("Thêm khách hàng thành công !");
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Thêm khách hàng thất bại !");
                }
            }
        }

        //Load Combobox Loai KH
        public void LoadTypeCus()
        {
            DataTable tb = cus.LoadTypeCus();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cbb_TypeCus.Items.Add(tb.Rows[i][1].ToString());
            }
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            this.rbtn_Men.Checked = true;
            txt_ID.Focus();
            LoadTypeCus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            
        }
    }
}