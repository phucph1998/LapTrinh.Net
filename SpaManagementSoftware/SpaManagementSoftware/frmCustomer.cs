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
        UserManager conn;
        CustomerManager pCus;
        public frmCustomer()
        {
            InitializeComponent();
            conn = new UserManager();
            pCus = new CustomerManager();
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
            typeCus = pCus.GetTableTypeCustomer();
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
            dGV_Customer.DataSource = pCus.GetListCustomer();
            SetColorTable();
        }

        private void tV_Member_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = this.tV_Member.SelectedNode;
            DataTable profileCus = new DataTable();
            if (selectNode.Tag == "1")
            {
                dGV_Customer.DataSource = pCus.GetListCustomer();
                SetColorTable();
            }
            else
            {
                if (selectNode.Tag == "2")
                {
                    dGV_Customer.DataSource = pCus.GetListTypeCustomer(selectNode.Text);
                    SetColorTable();
                }
            }
        }

        private void tSP_AddGroup_Click(object sender, EventArgs e)
        {
            frmAddTypeCus add = new frmAddTypeCus();
            add.ShowDialog();
            LoadTreeGroupCus();
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            frmAddCustomer add = new frmAddCustomer();
            add.CheckAsign = 1;
            add.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomer();
            SetColorTable();
        }

        private void dGV_Customer_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SetColorTable();
        }

        public C_Customer ProFileCus(DataGridView dgv)
        {
            C_Customer temp = new C_Customer();
            string codepro = dgv.CurrentRow.Cells[0].Value.ToString();
            string codeuser = dgv.CurrentRow.Cells[1].Value.ToString();
            string id = dgv.CurrentRow.Cells[2].Value.ToString();
            string lname = dgv.CurrentRow.Cells[3].Value.ToString();
            string fname = dgv.CurrentRow.Cells[4].Value.ToString();
            string sex = dgv.CurrentRow.Cells[5].Value.ToString();
            string phone = dgv.CurrentRow.Cells[6].Value.ToString();
            string address = dgv.CurrentRow.Cells[7].Value.ToString();
            string typecus = dgv.CurrentRow.Cells[9].Value.ToString();
            string stt = dgv.CurrentRow.Cells[10].Value.ToString();
            temp = new C_Customer(codepro, codeuser, id, lname, fname, sex, phone, address, typecus, stt);
            return temp;
        }
        private void dGV_Customer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmAddCustomer update = new frmAddCustomer();
            update.CheckAsign = 2;
            update.profile = ProFileCus(dGV_Customer);
            update.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomer();
            SetColorTable();
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            frmAddCustomer update = new frmAddCustomer();
            update.CheckAsign = 2;
            update.profile = ProFileCus(dGV_Customer);
            update.ShowDialog();
            dGV_Customer.DataSource = pCus.GetListCustomer();
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
                if (pCus.DeleteCustomer(phone))
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