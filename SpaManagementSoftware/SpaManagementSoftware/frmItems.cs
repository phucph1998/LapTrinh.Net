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
    public partial class frmItems : DevExpress.XtraEditors.XtraForm
    {
        C_Items _items;
        public frmItems()
        {
            InitializeComponent();
            _items = new C_Items();
        }

        public void LoadTreeGroupItem()
        {
            tV_GroupItem.Nodes.Clear();
            tV_GroupItem.Nodes.Add("Tất cả");
            tV_GroupItem.Nodes[0].Tag = "1";
            //tV_GroupItem.Nodes[0].ContextMenuStrip = cMS_GroupCus;
            DataTable typeCus = new DataTable();
            typeCus = _items.GetTableTypeItemMySQL();
            for (int i = 0; i < typeCus.Rows.Count; i++)
            {
                tV_GroupItem.Nodes[0].Nodes.Add(typeCus.Rows[i][0].ToString());
                tV_GroupItem.Nodes[0].Nodes[i].Tag = "2";
                //tV_GroupItem.Nodes[0].Nodes[i].ContextMenuStrip = cMS_GroupCus;
            }
            tV_GroupItem.Nodes[0].ExpandAll();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            LoadTreeGroupItem();
            dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
        }

        private void tV_GroupItem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = this.tV_GroupItem.SelectedNode;
            DataTable profileCus = new DataTable();
            if (selectNode.Tag == "1")
            {
                dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
            }
            else
            {
                if (selectNode.Tag == "2")
                {
                    dGV_Items.DataSource = _items.GetListItemFull_ForGroup(selectNode.Text);
                }
            }
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            frmAddItems frm = new frmAddItems();
            frm.ShowDialog();
        }

        private void dGV_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dGV_Items.CurrentRow != null)
            {
                frmAddItems frm = new frmAddItems();
                frm.IdItem = dGV_Items.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
            }
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            if (dGV_Items.CurrentRow != null)
            {
                frmAddItems frm = new frmAddItems();
                frm.IdItem = dGV_Items.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
            }
        }

        private void tSB_Delete_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn xóa mặt hàng : " + dGV_Items.CurrentRow.Cells["NAME"].Value.ToString(), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (r == DialogResult.Yes)
            {
                bool delete = _items.DeleteItems(dGV_Items.CurrentRow.Cells["ID"].Value.ToString());
                if (delete)
                {
                    XtraMessageBox.Show("Xóa mặt hàng thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Xóa mặt hàng thất bại!", "Thông báo");
                }
                dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
            }
        }

        private void tSP_AddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroupItems frm = new frmAddGroupItems();
            frm.ShowDialog();
            LoadTreeGroupItem();
            dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
        }

        private void tSP_EditGroup_Click(object sender, EventArgs e)
        {
            if (tV_GroupItem.SelectedNode != null)
            {
                frmAddGroupItems frm = new frmAddGroupItems();
                frm.NameGroup = tV_GroupItem.SelectedNode.Text;
                frm.ShowDialog();
                LoadTreeGroupItem();
                dGV_Items.DataSource = _items.GetTableItemsFullMySQL();
            }
        }

        private void tSP_Refresh_Click(object sender, EventArgs e)
        {
            LoadTreeGroupItem();
            XtraMessageBox.Show("Đã refresh !","Thông báo !");
        }
    }
}