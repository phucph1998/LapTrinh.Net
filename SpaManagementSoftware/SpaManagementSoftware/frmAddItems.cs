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
    public partial class frmAddItems : DevExpress.XtraEditors.XtraForm
    {
        C_Items _item;
        C_Unit _unit;
        C_GroupItem _groupItem;
        String idItem;
        List<string> listDelete = new List<string>();

        public string IdItem
        {
            get
            {
                return idItem;
            }

            set
            {
                idItem = value;
            }
        }

        public frmAddItems()
        {
            InitializeComponent();
            _item = new C_Items();
            _unit = new C_Unit();
            _groupItem = new C_GroupItem();
        }

        void LoadData()
        {
            //IdItem = "3";
            ColorData();
            cbbGroupItem.DataSource = _groupItem.GetDataGroupItem();
            cbbGroupItem.DisplayMember = "NAMEGROUP";
            cbbGroupItem.ValueMember = "ID";

            cbbUnit.DataSource = _unit.GetDataUnit();
            cbbUnit.DisplayMember = "NAME";
            cbbUnit.ValueMember = "ID";
            if (IdItem != null)
            {
                DataTable item = _item.GetListItemFull_ToIdItem(IdItem);//Lay du lieu day du cua mot mat hang
                DataTable temp = _item.GetListContentItem_toId(IdItem);//Lay chi tiet cua mat hang do
                for (int i = 0; i < temp.Rows.Count; i++)
                {
                    string id = temp.Rows[i][0].ToString();
                    string name = temp.Rows[i][1].ToString();
                    string unit = temp.Rows[i][2].ToString();
                    string number = temp.Rows[i][3].ToString();
                    string[] row = new string[] { id, name, unit, number };
                    dgv_ContentItem.Rows.Add(row);
                }
                txtID.Text = item.Rows[0][1].ToString();
                txtName.Text = item.Rows[0][4].ToString();
                txtPriceOut.Text = item.Rows[0][6].ToString();
                txtRose.Text = item.Rows[0][8].ToString();
                txtRoseRate.Text = item.Rows[0][9].ToString();
                cbbGroupItem.Text = item.Rows[0][0].ToString();
                cbbUnit.Text = item.Rows[0][5].ToString();
            }
            else
            {
                txtID.Text = (int.Parse(_item.CountIdItem()) + 1).ToString();
            }
        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSearchItems frm = new frmSearchItems();
            frm.ShowDialog();
            AddDataToDGView("1", frm.NameItem);
            //Lay duoc du lieu idItem
            //MessageBox.Show(frm.IdItem);
        }

        void AddDataToDGView(string num, string NameItem)
        {
            if (NameItem != null)
            {
                DataTable add = _item.GetTableItemsMySQL_ToName(NameItem);
                string id = add.Rows[0][0].ToString();
                string name = add.Rows[0][1].ToString();
                string number = num;
                string unit = add.Rows[0][3].ToString();
                if (dgv_ContentItem.Rows.Count == 0)
                {
                    string[] row = new string[] { id, name, unit, number };
                    dgv_ContentItem.Rows.Add(row);
                    ColorData();
                }
                else
                {
                    int r = dgv_ContentItem.Rows.Count;
                    for (int i = 0; i < r; i++)
                    {
                        if (id.Equals(dgv_ContentItem.Rows[i].Cells["ID"].Value.ToString()))
                        {
                            XtraMessageBox.Show("Vật tư bạn chọn đã có rồi !");
                            return;
                        }
                    }
                    string[] row = new string[] { id, name, unit, number };
                    dgv_ContentItem.Rows.Add(row);
                    ColorData();

                }
            }
        }

        public void ColorData()
        {
            dgv_ContentItem.Columns[1].DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
            dgv_ContentItem.Columns[2].DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
            dgv_ContentItem.Columns[3].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_ContentItem.CurrentRow != null && IdItem != null)
            {
                listDelete.Add(dgv_ContentItem.CurrentRow.Cells["ID"].Value.ToString());
                dgv_ContentItem.Rows.RemoveAt(dgv_ContentItem.CurrentRow.Index);
            }
            if (dgv_ContentItem.CurrentRow != null && IdItem == null)
            {
                dgv_ContentItem.Rows.RemoveAt(dgv_ContentItem.CurrentRow.Index);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                XtraMessageBox.Show("Bạn Chưa Nhập Tên Mặt Hàng !");
                txtName.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cbbGroupItem.Text))
            {
                XtraMessageBox.Show("Bạn Chưa Chọn Nhóm Mặt Hàng !");
                cbbGroupItem.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cbbUnit.Text))
            {
                XtraMessageBox.Show("Bạn Chưa Chọn Đơn Vị Tính !");
                cbbUnit.Focus();
                return;
            }
            if (IdItem != null)
            {
                //Cap nhat lai mat hang
                bool flagUpdate = _item.UpdateItems(txtID.Text, cbbGroupItem.SelectedValue.ToString(), cbbUnit.SelectedValue.ToString(), txtName.Text, txtPriceOut.Text, txtRose.Text, txtRoseRate.Text);
                if (flagUpdate)
                {
                    if (dgv_ContentItem.Rows.Count > 0)
                    {
                        //Co roi thi cap nhat so luong(neu co)
                        for (int m = 0; m < dgv_ContentItem.Rows.Count; m++)
                        {
                            bool flagUpdateCt = _item.UpdateContentItems(txtID.Text, dgv_ContentItem.Rows[m].Cells["ID"].Value.ToString(), dgv_ContentItem.Rows[m].Cells["NUMBER"].Value.ToString());
                        }
                        //chua co thi them vao
                        for (int i = 0; i < dgv_ContentItem.Rows.Count; i++)
                        {
                            bool flagUpdateAddCt = _item.AddContentItems(txtID.Text, dgv_ContentItem.Rows[i].Cells["ID"].Value.ToString(), dgv_ContentItem.Rows[i].Cells["NUMBER"].Value.ToString());
                        }
                    }
                    //Xoa neu co
                    for (int j = 0; j < listDelete.Count; j++)
                    {
                        bool flagUpdateDeleteCt = _item.DeleteContentItems(txtID.Text, listDelete[j].ToString());
                    }
                }
                XtraMessageBox.Show("Cập Nhật Mặt Hàng Thành Công !");
                return;
            }
            //Them mot mat hang moi (mat hang co the la goi dich vu hoac la mot san pham cu the)
            //Doi voi goi dich vu co the co hoac khong co noi dung vat tu nao
            bool flagAdd = _item.AddItems(txtID.Text, cbbGroupItem.SelectedValue.ToString(), cbbUnit.SelectedValue.ToString(), txtName.Text, txtPriceOut.Text, txtRose.Text, txtRoseRate.Text);
            if (flagAdd)
            {
                //Them noi dung
                if (dgv_ContentItem.Rows.Count > 0)
                {
                    //Them
                    for (int i = 0; i < dgv_ContentItem.Rows.Count; i++)
                    {
                        bool flagAddCtent = _item.AddContentItems(txtID.Text, dgv_ContentItem.Rows[i].Cells["ID"].Value.ToString(), dgv_ContentItem.Rows[i].Cells["NUMBER"].Value.ToString());
                    }
                }
            }
            XtraMessageBox.Show("Thêm Mặt Hàng Thành Công !");
            return;
        }
    }
}