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
using System.Configuration;
using System.IO;

namespace SpaManagementSoftware
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerManager cus;
        UserManager usr;
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
            //<add name="DbSpaDataContextConnectionString" connectionString="User Id=root;Password=123;Host=127.0.0.1;Database=db_spa;Persist Security Info=True;" />
            InitializeComponent();
            cus = new CustomerManager();
            usr = new UserManager();
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


        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập Tên Khách Hàng");
                txt_Name.Focus();
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
            if (txt_Birthday.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập ngày sinh khách hàng");
                cbb_TypeCus.Focus();
                return;
            }
            int add = cus.InsertCustomerMySQL(txt_Name.Text.ToString(), CheckSex(rbtn_Men, rbtn_Women).ToString(), txt_Phone.Text.ToString(), txt_Address.Text.ToString(), cbb_TypeCus.SelectedIndex + 1, txt_Birthday.Text);
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
                    this.Close();
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
            txt_IDProfile.Text = profile.ID_PROFILE.ToString();
            txt_Name.Text = profile.NAME.ToString();
            txt_Phone.Text = profile.PHONE.ToString();
            txt_Address.Text = profile.ADDRESS.ToString();
            cbb_TypeCus.Text = profile.TYPE_CUS.ToString();
            txt_Birthday.Text = profile.bIRTHDAY.ToString();
            cus.LoadImgCus(profile.ID_PROFILE.ToString(), ptb_ImageCus);
            if (profile.SEX.ToString() == "Nữ")
            {
                rbtn_Men.Checked = false;
                rbtn_Women.Checked = true;
            }
        }
        //Load Combobox Loai KH
        public void LoadTypeCus()
        {
            //DataTable tb = cus.LoadTypeCusMySQL();
            //for (int i = 0; i < tb.Rows.Count; i++)
            //{
            //    cbb_TypeCus.Items.Add(tb.Rows[i][1].ToString());
            //}
            cbb_TypeCus.DataSource = cus.LoadTypeCusMySQL();
            cbb_TypeCus.DisplayMember = "NAME";
            cbb_TypeCus.ValueMember = "NAME";
            if (this.CheckAsign == 1)
            {
                btn_Update.Enabled = false;
                txt_IDProfile.Text = (cus.GetIDMaxProFileMySQL() + 1).ToString();
            }
            else
            {
                if (this.CheckAsign == 2)
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
            txt_Name.Focus();
            LoadTypeCus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập Tên Khách Hàng");
                txt_Name.Focus();
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
            if (txt_Birthday.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Phải nhập ngày sinh khách hàng");
                cbb_TypeCus.Focus();
                return;
            }
            bool update = cus.UpdateCustomerMySQL(Int32.Parse(txt_IDProfile.Text), txt_Name.Text, CheckSex(rbtn_Men, rbtn_Women).ToString(), txt_Phone.Text, txt_Address.Text, txt_Birthday.Text, cus.GetID_TypeCusMySQL(cbb_TypeCus.Text));
            if (update)
            {
                XtraMessageBox.Show("Cập nhật khách hàng thành công");
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Cập nhật thất bại !");
            }
        }

        private void btn_ImportImg_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            string file = openDialog.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            try
            {
                Image myImage = Image.FromFile(file);
                ptb_ImageCus.Image = myImage;
            }
            catch
            {
                return;
            }
        }

        private void btn_SaveImg_Click(object sender, EventArgs e)
        {
            if (cus.SaveImgCus(txt_IDProfile.Text, ptb_ImageCus))
            {
                XtraMessageBox.Show("Lưu ảnh thành công");
            }
            else
            {
                XtraMessageBox.Show("Lưu ảnh thất bại");
            }
        }
    }
}