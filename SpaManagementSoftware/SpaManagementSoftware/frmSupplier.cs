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
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        C_Supplier _sup;
        public frmSupplier()
        {
            InitializeComponent();
            _sup = new C_Supplier();
        }

        //Load nhom nha cung cap
        public void LoadTreeGroupSup()
        {
            _sup = new C_Supplier();
            tV_GroupSup.Nodes.Clear();
            tV_GroupSup.Nodes.Add("Tất cả");
            tV_GroupSup.Nodes[0].Tag = "1";
            tV_GroupSup.Nodes[0].ContextMenuStrip = cMS_GroupSup;
            DataTable typeCus = new DataTable();
            typeCus = _sup.GetTableTypeSupplierMySQL();
            for (int i = 0; i < typeCus.Rows.Count; i++)
            {
                tV_GroupSup.Nodes[0].Nodes.Add(typeCus.Rows[i][0].ToString());
                tV_GroupSup.Nodes[0].Nodes[i].Tag = "2";
                tV_GroupSup.Nodes[0].Nodes[i].ContextMenuStrip = cMS_GroupSup;
            }
            tV_GroupSup.Nodes[0].ExpandAll();
        }


        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadTreeGroupSup();
            dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
            SetColorTable();
        }

        private void tSP_AddGroup_Click(object sender, EventArgs e)
        {
            frmAddGroupSupplier frm = new frmAddGroupSupplier();
            frm.ShowDialog();
            LoadTreeGroupSup();
        }

        private void tSB_Add_Click(object sender, EventArgs e)
        {
            frmAddSupplier frm = new frmAddSupplier();
            frm.ShowDialog();
            dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
            SetColorTable();
        }

        public Supplier InfoSupplier()
        {
            string Id = dGV_Supplier.CurrentRow.Cells["ID"].Value.ToString();
            string IdGroup = dGV_Supplier.CurrentRow.Cells["ID_GROUP"].Value.ToString();
            string Name = dGV_Supplier.CurrentRow.Cells["NAME"].Value.ToString();
            string Phone = dGV_Supplier.CurrentRow.Cells["PHONE"].Value.ToString();
            string Email = dGV_Supplier.CurrentRow.Cells["EMAIL"].Value.ToString();
            string Address = dGV_Supplier.CurrentRow.Cells["ADDRESS"].Value.ToString();
            string Taxcode = dGV_Supplier.CurrentRow.Cells["TAX_CODE"].Value.ToString();
            Supplier sup = new Supplier(Id, Name, Phone, Email, Address, Taxcode, IdGroup);
            return sup;
        }
        //Cài đặt màu từng dòng cho dgv
        public void SetColorTable()
        {
            for (int i = 0; i < dGV_Supplier.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dGV_Supplier.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else
                {
                    dGV_Supplier.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dGV_Supplier_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmAddSupplier frm = new frmAddSupplier();
            if (dGV_Supplier.CurrentRow != null)
            {
                frm._sup = InfoSupplier();
                frm.ShowDialog();
                dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
            }
            SetColorTable();
        }

        private void tSP_Edit_Click(object sender, EventArgs e)
        {
            frmAddSupplier frm = new frmAddSupplier();
            if (dGV_Supplier.CurrentRow != null)
            {
                frm._sup = InfoSupplier();
                frm.ShowDialog();
                dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
            }
            SetColorTable();
        }

        private void tSB_Delete_Click(object sender, EventArgs e)
        {
            if (dGV_Supplier.CurrentRow != null)
            {
                DialogResult r;
                r = XtraMessageBox.Show("Bạn có chắc muốn xóa Nhà CC: " + dGV_Supplier.CurrentRow.Cells["NAME"].Value.ToString(), "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    bool flag = _sup.DeleteSupplierMySQL(dGV_Supplier.CurrentRow.Cells["ID"].Value.ToString());
                    if (flag)
                    {
                        XtraMessageBox.Show("Xóa thành công !");
                        dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
                        SetColorTable();
                    }
                    else
                    {
                        XtraMessageBox.Show("Xóa thất bại ! Vui lòng kiểm tra lại các phiếu nhập!");
                    }
                }
            }
        }

        private void tV_GroupSup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = tV_GroupSup.SelectedNode;
            if (selectNode.Tag == "1")
            {
                dGV_Supplier.DataSource = _sup.GetListSupplierMySQL();
                SetColorTable();
            }
            else
            {
                dGV_Supplier.DataSource = _sup.GetListSupplier_ForGroup(selectNode.Text);
                SetColorTable();
            }
        }
    }
}