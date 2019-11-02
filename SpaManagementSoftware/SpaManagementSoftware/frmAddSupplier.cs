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
using System.Net;
using SpaClassLibrary;

namespace SpaManagementSoftware
{
    public partial class frmAddSupplier : DevExpress.XtraEditors.XtraForm
    {
        public Supplier _sup;
        C_Supplier _supdll;
        public Supplier Sup
        {
            get { return _sup; }
            set { _sup = value; }
        }
        public frmAddSupplier()
        {
            InitializeComponent();
            _supdll = new C_Supplier();
        }
        public void LoadSupplier()
        {
            txt_ID.Text = _sup.PID.ToString();
            txt_Name.Text = _sup.PName.ToString();
            txt_Phone.Text = _sup.PPhone.ToString();
            txt_TaxCode.Text = _sup.PTaxcode.ToString();
            txt_Email.Text = _sup.PEmail.ToString();
            txt_Address.Text = _sup.PAddress.ToString();
            cbb_Group.Text = _supdll.GetNameGroupSupMySQL(_sup.PIdgroup);
        }
        private void frmAddSupplier_Load(object sender, EventArgs e)
        {
            cbb_Group.DataSource = _supdll.GetTableTypeSupplierMySQL();
            cbb_Group.DisplayMember = "NAME_GROUP";
            if (_sup != null)
            {
                LoadSupplier();
            }
            else
            {
                txt_ID.Text = (_supdll.GetIDMaxSupplierMySQL() + 1).ToString();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (_supdll.IsSupplierMySQL(txt_Name.Text) != 0)
            {
                //Cap nhat thong tin
                bool flag = _supdll.UpdateSupplierMySQL(txt_ID.Text, txt_Name.Text, txt_Phone.Text, txt_Email.Text, txt_Address.Text, txt_TaxCode.Text, _supdll.GetIdGroupSupMySQL(cbb_Group.Text));
                if (flag)
                {
                    XtraMessageBox.Show("Cập nhật thành công !");
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Lỗi Cập Nhật !");
                }
            }
            else
            {
                //Them moi
                if (txt_Name.Text.Trim() == string.Empty)
                {
                    XtraMessageBox.Show("Chưa nhập Tên Nhà Cung Cấp");
                    txt_Name.Focus();
                    return;
                }
                int add = _supdll.InsertSupplierMySQL(txt_Name.Text, txt_Phone.Text, txt_Email.Text, txt_Address.Text, txt_TaxCode.Text, _supdll.GetIdGroupSupMySQL(cbb_Group.Text));
                if (add == 2)
                {
                    XtraMessageBox.Show("Đã Thêm Mới 1 Nhà Cung Cấp Thành Công !");
                    this.Close();
                }
                if (add == 3)
                {
                    XtraMessageBox.Show("Lỗi Khi Thêm!");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Phone_Leave(object sender, EventArgs e)
        {
            if (txt_Phone.Text.Length < 10 || txt_Phone.Text.Length > 10)
            {
                errPro.SetError(txt_Phone, "Invalid phone !");
            }
            else
            {
                errPro.Clear();
            }
        }

        private void txt_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Email_Leave(object sender, EventArgs e)
        {
            string str = txt_Email.Text;
            try
            {
                var mail = new System.Net.Mail.MailAddress(str);
                errPro.Clear();
            }
            catch
            {
                errPro.SetError(txt_Email, "Invalid email !");
            }
        }

        private void txt_TaxCode_Leave(object sender, EventArgs e)
        {
            if (txt_TaxCode.Text.Length > 11)
            {
                errPro.SetError(txt_TaxCode, "Invalid tax code!");
            }
            else
            {
                errPro.Clear();
            }
        }
    }
}