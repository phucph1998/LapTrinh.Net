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
        frmCustomer temp;
        public C_Customer profile;
        private int checkAsign;

        public int CheckAsign
        {
            get { return checkAsign; }
            set { checkAsign = value; }
        }
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
        
        public void CheckIsEmpty()
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
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CheckIsEmpty();
            int add = cus.InsertCustomer(txt_ID.Text, txt_LName.Text, txt_FName.Text, CheckSex(rbtn_Men, rbtn_Women), txt_Phone.Text, txt_Address.Text, cbb_TypeCus.SelectedIndex + 1);
            if (add == 1)
            {
                XtraMessageBox.Show("Khách hàng đã tồn tại, và đã bị khóa!");
                return;
            }
            else
            {
                if (add == 2)
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
        //
        public void LoadProfile()
        {
            txt_ID.Text = profile.IDENFITICATION.ToString();
            txt_LName.Text = profile.LAST_NAME.ToString();
            txt_FName.Text = profile.FIRST_NAME.ToString();
            txt_Phone.Text = profile.PHONE.ToString();
            txt_Address.Text = profile.ADDRESS.ToString();
            cbb_TypeCus.Text = profile.TYPE_CUS.ToString();
            if(profile.SEX.ToString() =="Nữ")
            {
                rbtn_Men.Checked = false;
                rbtn_Women.Checked = true;
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
            if (this.CheckAsign == 1)
            {
                btn_Update.Enabled = false;
            }
            else
            {
                if(this.CheckAsign == 2)
                {
                    LoadProfile();
                    btn_Update.Enabled = true;
                    btn_Add.Enabled = false;
                }
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
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CheckIsEmpty();
            bool update = cus.UpdateCustomer(profile.ID_PROFILE.ToString(), txt_ID.Text, txt_LName.Text, txt_FName.Text, CheckSex(rbtn_Men, rbtn_Women), txt_Phone.Text,txt_Address.Text,cus.GetID_TypeCus(cbb_TypeCus.Text));
            if(update)
            {
                XtraMessageBox.Show("Cập nhật khách hàng thành công");
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại !");
            }
        }
    }
}