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
    public partial class frmSearchItems : DevExpress.XtraEditors.XtraForm
    {
        C_Items _item;
        String nameItem;

        public string NameItem
        {
            get
            {
                return nameItem;
            }

            set
            {
                nameItem = value;
            }
        }

        public frmSearchItems()
        {
            InitializeComponent();
            _item = new C_Items();
        }
        public void LoadTreeGroupItem()
        {
            dgV_Items.DataSource = _item.GetTableItemsMySQL();
            tV_GroupItem.Nodes.Clear();
            tV_GroupItem.Nodes.Add("Tất cả");
            tV_GroupItem.Nodes[0].Tag = "1";
            //tV_GroupItem.Nodes[0].ContextMenuStrip = cMS_GroupCus;
            DataTable typeCus = new DataTable();
            typeCus = _item.GetTableTypeItemMySQL();
            for (int i = 0; i < typeCus.Rows.Count; i++)
            {
                tV_GroupItem.Nodes[0].Nodes.Add(typeCus.Rows[i][0].ToString());
                tV_GroupItem.Nodes[0].Nodes[i].Tag = "2";
                //tV_Member.Nodes[0].Nodes[i].ContextMenuStrip = cMS_GroupCus;
            }
            tV_GroupItem.Nodes[0].ExpandAll();
        }

        private void frmSearchItems_Load(object sender, EventArgs e)
        {
            LoadTreeGroupItem();
        }

        private void tV_GroupItem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = this.tV_GroupItem.SelectedNode;
            DataTable profileCus = new DataTable();
            if (selectNode.Tag == "1")
            {
                dgV_Items.DataSource = _item.GetTableItemsMySQL();
            }
            else
            {
                if (selectNode.Tag == "2")
                {
                    dgV_Items.DataSource = _item.GetListItem_ForGroup(selectNode.Text);
                }
            }
        }

        private void txtNameItem_TextChanged(object sender, EventArgs e)
        {
            if (txtNameItem.Text.Trim() != string.Empty)
            {
                dgV_Items.DataSource = _item.GetTableItemsMySQL_ToName(txtNameItem.Text);
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dgV_Items.CurrentRow != null)
            {
                nameItem = dgV_Items.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
                this.Close();
            }
        }

        private void dgV_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChoose.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}