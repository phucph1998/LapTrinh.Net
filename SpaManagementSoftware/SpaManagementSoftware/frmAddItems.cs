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
        String idItem;

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
        }

        void LoadData()
        {
            IdItem = "3";
            if (IdItem != null)
            {
                DataTable item = _item.GetListItemFull_ToIdItem(IdItem);
                dgv_ContentItem.DataSource = _item.GetListContentItem_toId(IdItem);
                txtID.Text = item.Rows[0][1].ToString();
                txtName.Text = item.Rows[0][4].ToString();
                txtPriceOut.Text = item.Rows[0][6].ToString();
                txtRose.Text = item.Rows[0][8].ToString();
                txtRoseRate.Text = item.Rows[0][9].ToString();
                cbbGroupItem.Text = item.Rows[0][0].ToString();
                cbbUnit.Text = item.Rows[0][5].ToString();
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
                    //ColorData();
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
                    //ColorData();

                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}