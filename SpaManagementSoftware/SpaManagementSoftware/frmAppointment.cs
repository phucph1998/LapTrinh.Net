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
    public partial class frmAppointment : DevExpress.XtraEditors.XtraForm
    {
        String idReceiptAppoint;
        String idChair;
        C_Receipt _receipt;
        C_DetailsReceipt _dtreceipt;
        C_Items _item;
        C_Unit _unit;
        C_Staff _staff;

        public string IdReceiptAppoint
        {
            get
            {
                return idReceiptAppoint;
            }

            set
            {
                idReceiptAppoint = value;
            }
        }

        public string IdChair
        {
            get
            {
                return idChair;
            }

            set
            {
                idChair = value;
            }
        }

        public frmAppointment()
        {
            _item = new C_Items();
            _unit = new C_Unit();
            _staff = new C_Staff();
            _receipt = new C_Receipt();
            _dtreceipt = new C_DetailsReceipt();
            InitializeComponent();
        }

        public void LoadReceipt_Appointment()
        {
            //Load tat ca thong tin thuoc loai hoa don đặt typereceipt = 3
            dgv_Receipt.DataSource = _receipt.GetDataAppointment();
        }
        private void frmAppointment_Load(object sender, EventArgs e)
        {
            LoadReceipt_Appointment();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //Lấy mã hóa đơn gửi lại frmUseService để thực hiện chuyển từ hóa đơn đặt sang hóa đơn
            if (dgv_Receipt.CurrentRow != null)
            {
                IdReceiptAppoint = dgv_Receipt.CurrentRow.Cells[1].Value.ToString();
                IdChair = dgv_Receipt.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }

        }
        public void LoadDtReceipt_Appoint()
        {
            dgv_DetailReceipt.Rows.Clear();
            DataTable listDt = _dtreceipt.GetDTReceipt(dgv_Receipt.CurrentRow.Cells[1].Value.ToString());
            for (int j = 0; j < listDt.Rows.Count; j++)
            {
                string idItem = listDt.Rows[j][2].ToString(); ;
                string product = _item.GetNameItem(listDt.Rows[j][2].ToString());//Lay ten san pham
                string unit = _unit.GetNameUnit(_item.GetIdUnit(listDt.Rows[j][2].ToString()));//Lay ten don vi
                string price = listDt.Rows[j][5].ToString();
                string idStaff = listDt.Rows[j][1].ToString();
                string nameStaff = _staff.GetNameStaff(listDt.Rows[j][1].ToString());//Lay ten nhan vien
                string num = listDt.Rows[j][4].ToString(); ;
                string saleoff = listDt.Rows[j][3].ToString();
                string total = listDt.Rows[j][6].ToString();
                string[] row = new string[] { idItem, product, unit, num, price, saleoff, total, idStaff, nameStaff };
                dgv_DetailReceipt.Rows.Add(row);
            }
        }
        private void dgv_Receipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Receipt.CurrentRow != null)
            {
                //Load chi tiet hoa don dat
                LoadDtReceipt_Appoint();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNameCus_TextChanged(object sender, EventArgs e)
        {
            if (txtNameCus.Text.Trim() != string.Empty)
            {
                //Thuc hien tim kiem
                dgv_Receipt.DataSource = _receipt.SearchReceipt_ToNameCus(txtNameCus.Text);
            }
            if(txtNameCus.Text.Length == 0)
            {
                LoadReceipt_Appointment();
            }
        }
    }
}