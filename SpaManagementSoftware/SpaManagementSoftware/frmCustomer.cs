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
                if(i%2!=0)
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
            DataTable typeCus = new DataTable();
            typeCus = pCus.GetTableTypeCustomer();
            for (int i = 0; i < typeCus.Rows.Count; i++)
            {
                tV_Member.Nodes[0].Nodes.Add(typeCus.Rows[i][0].ToString());
                tV_Member.Nodes[0].Nodes[i].Tag = "2";
            }
            tV_Member.Nodes[0].ExpandAll();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadTreeGroupCus();
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
    }
}