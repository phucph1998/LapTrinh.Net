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
    public partial class frmSearchCustomer : DevExpress.XtraEditors.XtraForm
    {
        CustomerManager _cus = new CustomerManager();
        public string idCus = null;
        public string nameCus = null;

        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            dGV_Customer.DataSource = _cus.GetListCustomerMySQL();
        }

        public C_Customer ProFileCus(DataGridView dgv)
        {
            C_Customer temp = new C_Customer();
            string image = dgv.CurrentRow.Cells["IMAGE"].Value.ToString();
            string id = dgv.CurrentRow.Cells["ID_PROFILE"].Value.ToString();
            string name = dgv.CurrentRow.Cells["NAME"].Value.ToString();
            string sex = dgv.CurrentRow.Cells["SEX"].Value.ToString();
            string phone = dgv.CurrentRow.Cells["PHONE"].Value.ToString();
            string address = dgv.CurrentRow.Cells["ADDRESS"].Value.ToString();
            string typecus = dgv.CurrentRow.Cells["NAME_TYPE"].Value.ToString();
            string birthday = dgv.CurrentRow.Cells["BIRTHDAY"].Value.ToString();
            string stt = dgv.CurrentRow.Cells["STATUS"].Value.ToString();
            temp = new C_Customer(image, id, name, sex, phone, address, birthday, typecus, stt);
            return temp;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.CheckAsign = 1;
            frm.ShowDialog();
            dGV_Customer.DataSource = _cus.GetListCustomerMySQL();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddCustomer update = new frmAddCustomer();
            update.CheckAsign = 2;
            update.profile = ProFileCus(dGV_Customer);
            update.ShowDialog();
            dGV_Customer.DataSource = _cus.GetListCustomerMySQL();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                dGV_Customer.DataSource = _cus.GetListCusTomerMySQL_Name(txtSearch.Text);
            }
            else
            {
                dGV_Customer.DataSource = _cus.GetListCustomerMySQL();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dGV_Customer.CurrentRow != null)
            {
                idCus = dGV_Customer.CurrentRow.Cells["ID_PROFILE"].Value.ToString();
                nameCus = dGV_Customer.CurrentRow.Cells["NAME"].Value.ToString();
                this.Close();
            }
        }

        private void dGV_Customer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Customer.CurrentRow != null)
            {
                idCus = dGV_Customer.CurrentRow.Cells["ID_PROFILE"].Value.ToString();
                nameCus = dGV_Customer.CurrentRow.Cells["NAME"].Value.ToString();
                this.Close();
            }
        }
    }
}