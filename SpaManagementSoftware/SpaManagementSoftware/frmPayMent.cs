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
    public partial class frmPayMent : DevExpress.XtraEditors.XtraForm
    {
        string idReceipt, nameChair;//Từ mã hóa đơn => tổng tiền, chi tiết hóa đơn,
        public bool flagPayment = false;
        C_Receipt _receipt;
        C_DetailsReceipt _dtreceipt;
        public frmPayMent()
        {
            _receipt = new C_Receipt();
            _dtreceipt = new C_DetailsReceipt();
            InitializeComponent();
        }

        public string IdReceipt
        {
            get
            {
                return idReceipt;
            }

            set
            {
                idReceipt = value;
            }
        }

        public string NameChair
        {
            get
            {
                return nameChair;
            }

            set
            {
                nameChair = value;
            }
        }

        public void LoadReceipt()
        {
            lbl_Chair.Text = NameChair;
            //Load tien
            txt_ToTal.Text = _receipt.GetMoneyReceipt(IdReceipt);
        }

        private void btn_CloseBillNoPrint_Click(object sender, EventArgs e)
        {
            flagPayment = true;
            //Cap nhat trang thai hoa don typereceipt
            bool flag = _receipt.PayMent(idReceipt);
            if (flag)
            {
                XtraMessageBox.Show("Thanh Toán Thành Công!", "Thông báo");
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Thanh Toán Thất Bại !", "Thông báo");
            }
        }

        private void btn_CloseBillPrint_Click(object sender, EventArgs e)
        {
            flagPayment = true;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_MoneyCus_TextChanged(object sender, EventArgs e)
        {
            if (txt_MoneyCus.Text.Trim() != string.Empty)
            {
                Double sumMoney = Double.Parse(txt_ToTal.Text);
                Double moneyCus = Double.Parse(txt_MoneyCus.Text);
                txt_Refund.Text = String.Format("{0:#,##0.##}", (sumMoney - moneyCus));
            }
        }

        private void txt_MoneyCus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmPayMent_Load(object sender, EventArgs e)
        {
            LoadReceipt();
        }
    }
}