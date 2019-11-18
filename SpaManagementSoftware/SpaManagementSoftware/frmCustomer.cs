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
using System.Data.SqlClient;

namespace SpaManagementSoftware
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        UserManager usr;
        CustomerManager pCus;
        public frmCustomer()
        {
            InitializeComponent();
            usr = new UserManager();
            pCus = new CustomerManager();
            Properties.Settings.Default["DbSpaDataContextConnectionString"] = usr.GetStringConfigMySQL();
            Properties.Settings.Default.Save();
        }
        //Cài đặt màu từng dòng cho dgv
        public void SetColorTable()
        {
            for (int i = 0; i < dGV_Customer.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dGV_Customer.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    dGV_Customer.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        //Load cây Nhóm khách hàng
        public void LoadTreeGroupCus()
        {
            tV_Member.Nodes.Clear();
            tV_Member.Nodes.Add("Tất cả");
            tV_Member.Nodes[0].Tag = "1";
            tV_Member.Nodes[0].ContextMenuStrip = cMS_GroupCus;
            DataTable typeCus = new DataTable();
            typeCus = pCus.GetTableTypeCustomerMySQL();
            for (int i = 0; i < typeCus.Rows.Count; i++)
            {
                tV_Member.Nodes[0].Nodes.Add(typeCus.Rows[i][0].ToString());
                tV_Member.Nodes[0].Nodes[i].Tag = "2";
                tV_Member.Nodes[0].Nodes[i].ContextMenuStrip = cMS_GroupCus;
            }
            tV_Member.Nodes[0].ExpandAll();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadTreeGroupCus();
            dGV_Customer.DataSource = pCus.GetListCustomerMySQL();
            
            SetColorTable();
        }

        private void tV_Member_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = this.tV_Member.SelectedNode;
            DataTable profileCus = new DataTable();
            if (selectNode.Tag == "1")
            {
                dGV_Customer.DataSource = pCus.GetListCustomerMySQL();
                SetColorTable();
            }
            else
            {
                if (selectNode.Tag == "2")
                {
                    dGV_Customer.DataSource = pCus.GetListTypeCustomerMySQL(pCus.GetID_TypeCusMySQL(selectNode.Text).ToString());
                    SetColorTable();
                }
            }
        }

        private void tSP_AddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroupCus add = new frmAddGroupCus();
            add.ShowDialog();
            LoadTreeGroupCus();
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            frmAddCustomer add = new frmAddCustomer();
            add.CheckAsign = 1;
            add.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomerMySQL();
            SetColorTable();
        }

        private void dGV_Customer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetColorTable();
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
            temp = new C_Customer(image,id, name, sex, phone, address, birthday, typecus, stt);
            return temp;
        }
        private void dGV_Customer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmAddCustomer update = new frmAddCustomer();
            update.CheckAsign = 2;
            update.profile = ProFileCus(dGV_Customer);
            update.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomerMySQL();
            SetColorTable();
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            frmAddCustomer update = new frmAddCustomer();
            update.CheckAsign = 2;
            update.profile = ProFileCus(dGV_Customer);
            update.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomerMySQL();
            SetColorTable();
        }

        private void tSB_Delete_Click(object sender, EventArgs e)
        {
            string lname = dGV_Customer.CurrentRow.Cells[3].Value.ToString();
            string fname = dGV_Customer.CurrentRow.Cells[4].Value.ToString();
            string phone = dGV_Customer.CurrentRow.Cells[6].Value.ToString();
            
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn xóa khách hàng " + lname + " " + fname, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(r == DialogResult.Yes)
            {
                if (pCus.DeleteCustomerMySQL(phone))
                {
                    XtraMessageBox.Show("Xóa thành công");
                }
                else
                {
                    XtraMessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                return;
            }
        }

        private void thêmNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}