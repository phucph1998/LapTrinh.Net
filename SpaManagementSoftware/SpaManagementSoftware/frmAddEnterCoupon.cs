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
using System.Data;

namespace SpaManagementSoftware
{
    public partial class frmAddEnterCoupon : DevExpress.XtraEditors.XtraForm
    {
        C_Items _item;
        C_Staff _staff;
        C_Supplier _sup;
        C_Enter _enter;
        public String _idEnter;
        public String username;

        public String IdEnter
        {
            get { return _idEnter; }
            set { _idEnter = value; }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public frmAddEnterCoupon()
        {
            InitializeComponent();
            _item = new C_Items();
            _staff = new C_Staff();
            _sup = new C_Supplier();
            _enter = new C_Enter();
        }

        public void LoadTreeGroupItem()
        {
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

        public void LoadStaff()
        {
            cbb_Staff.DataSource = _staff.LoadListStaff();
            cbb_Staff.DisplayMember = "NAME";
            cbb_Staff.ValueMember = "ID";
        }

        public void LoadSupplier()
        {
            cbb_Supplier.DataSource = _sup.LoadId_NameSuplier();
            cbb_Supplier.DisplayMember = "NAME";
            cbb_Supplier.ValueMember = "ID";
        }

        public void LoadEnterCoupon()
        {
            txt_ID.Text = IdEnter;
            //Load du lieu phieu nhap,chi tiet phieu nhap
            DataTable temp = _enter.LoadEnterCoupon_Id(IdEnter);
            for (int i = 0; i < temp.Columns.Count; i++)
            {
                dtP_DayCreate.Text = temp.Rows[0][0].ToString();
                cbb_Supplier.Text = temp.Rows[0][1].ToString();
                cbb_Reson.Text = temp.Rows[0][2].ToString();
                cbb_Staff.Text = temp.Rows[0][3].ToString();
            }
            DataTable list = _item.GetListDetail_IdEnter(IdEnter);
            for (int i = 0; i < list.Rows.Count; i++)
            {

                string id = list.Rows[i][0].ToString();
                string name = list.Rows[i][1].ToString();
                string number = list.Rows[i][3].ToString();
                string unit = list.Rows[i][2].ToString();
                string price = list.Rows[i][4].ToString();
                string money = list.Rows[i][5].ToString();
                string[] row = new string[] { name, number, unit, price, money, id };
                dgV_DetailsCoupon.Rows.Add(row);
            }
            SumMoneyItem();
        }
        private void frmAddEnterCoupon_Load(object sender, EventArgs e)
        {
            LoadTreeGroupItem();
            LoadStaff();
            LoadSupplier();
            dgV_Items.DataSource = _item.GetTableItemsMySQL();
            if (IdEnter != null)
            {
                LoadEnterCoupon();
            }
            else
            {
                txt_ID.Text = (_enter.GetIdMaxEnterCoupon() + 1).ToString();
            }
            ColorData();
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

        void AddDataToDGView(int num)
        {
            if (dgV_Items.CurrentRow != null)
            {
                txt_Price.Text = dgV_Items.CurrentRow.Cells["PRICE_IN"].Value.ToString();
                string id = dgV_Items.CurrentRow.Cells["ID"].Value.ToString();
                string name = dgV_Items.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
                string number = num.ToString();
                string unit = dgV_Items.CurrentRow.Cells["NAME_UNIT"].Value.ToString();
                string price = txt_Price.Text;
                string money = (Convert.ToInt32(txt_Number.Text) * Convert.ToDouble(txt_Price.Text)).ToString();
                if (dgV_DetailsCoupon.Rows.Count == 0)
                {
                    string[] row = new string[] { name, number, unit, price, money, id };
                    dgV_DetailsCoupon.Rows.Add(row);
                    SumMoneyItem();
                    ColorData();
                }
                else
                {
                    int r = dgV_DetailsCoupon.Rows.Count;
                    for (int i = 0; i < r; i++)
                    {
                        if (id.Equals(dgV_DetailsCoupon.Rows[i].Cells["ID_ITEM"].Value.ToString()))
                        {
                            dgV_DetailsCoupon.Rows[i].Cells["NUMBER"].Value = Convert.ToInt32(dgV_DetailsCoupon.Rows[i].Cells[1].Value.ToString()) + num;
                            dgV_DetailsCoupon.Rows[i].Cells["SUM_MONEY"].Value = Convert.ToInt32(dgV_DetailsCoupon.Rows[i].Cells["NUMBER"].Value.ToString()) * Convert.ToInt32(dgV_DetailsCoupon.Rows[i].Cells["PRICE_IN_2"].Value.ToString());
                            SumMoneyItem();
                            ColorData();
                            return;
                        }
                    }
                    string[] row = new string[] { name, number, unit, price, money, id };
                    dgV_DetailsCoupon.Rows.Add(row);
                    SumMoneyItem();
                    ColorData();
                }
            }
        }

        private void dgV_Items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddDataToDGView(1);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddDataToDGView(Int32.Parse(txt_Number.Text));
        }

        private void dgV_Items_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_Items.CurrentRow != null)
            {
                txt_Price.Text = dgV_Items.CurrentRow.Cells["PRICE_IN"].Value.ToString();
            }
        }

        void SumMoneyItem()
        {
            int sum = 0;
            for (int i = 0; i < dgV_DetailsCoupon.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgV_DetailsCoupon.Rows[i].Cells["SUM_MONEY"].Value.ToString());
            }
            txt_MoneyItem.Text = String.Format("{0:#,##0.##}", sum);
            txt_SumMoney.Text = String.Format("{0:#,##0.##}", sum);
        }

        private void txt_SaleOff_TextChanged(object sender, EventArgs e)
        {
            if (txt_SaleOff.Text.Trim() != string.Empty)
            {
                Double sumMoney = Double.Parse(txt_MoneyItem.Text);
                Double sale = Double.Parse(txt_SaleOff.Text);
                txt_SumMoney.Text = String.Format("{0:#,##0.##}", (sumMoney - sale));
            }
        }

        private void txt_SaleOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_SaleOff_Leave(object sender, EventArgs e)
        {
            if (txt_SaleOff.Text.Trim() != string.Empty)
            {
                Double sumMoney = Double.Parse(txt_MoneyItem.Text);
                Double sale = Double.Parse(txt_SaleOff.Text);
                txt_SumMoney.Text = String.Format("{0:#,##0.##}", (sumMoney - sale));
            }
            else
            {
                txt_SaleOff.Text = "0";
                txt_SumMoney.Text = String.Format("{0:#,##0.##}", txt_MoneyItem.Text);
            }
        }

        private void txt_MoneyItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SumMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void ColorData()
        {
            dgV_DetailsCoupon.Columns[0].DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
            dgV_DetailsCoupon.Columns[2].DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
            dgV_DetailsCoupon.Columns[4].DefaultCellStyle.BackColor = System.Drawing.Color.DodgerBlue;
            dgV_DetailsCoupon.Columns[1].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
            dgV_DetailsCoupon.Columns[3].DefaultCellStyle.BackColor = System.Drawing.Color.Gold;
        }

        private void dgV_DetailsCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgV_DetailsCoupon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgV_DetailsCoupon.CurrentRow != null)
                {
                    dgV_DetailsCoupon.CurrentRow.Cells["SUM_MONEY"].Value = Convert.ToInt32(dgV_DetailsCoupon.CurrentRow.Cells["NUMBER"].Value.ToString()) * Convert.ToInt32(dgV_DetailsCoupon.CurrentRow.Cells["PRICE_IN_2"].Value.ToString());
                    SumMoneyItem();
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (dgV_DetailsCoupon.CurrentRow != null)
            {
                dgV_DetailsCoupon.CurrentRow.Cells["NUMBER"].Value = Convert.ToInt32(dgV_DetailsCoupon.CurrentRow.Cells["NUMBER"].Value) + 1;
            }
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (dgV_DetailsCoupon.CurrentRow != null)
            {
                dgV_DetailsCoupon.CurrentRow.Cells["NUMBER"].Value = Convert.ToInt32(dgV_DetailsCoupon.CurrentRow.Cells["NUMBER"].Value) - 1;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (dgV_DetailsCoupon.CurrentRow != null)
            {
                dgV_DetailsCoupon.Rows.RemoveAt(dgV_DetailsCoupon.CurrentRow.Index);
            }
        }
        public string CheckReson()
        {
            if (cbb_Reson.Text.Trim() != string.Empty)
            {
                return cbb_Reson.Text;
            }
            return "Nhập hàng";
        }
        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbb_Supplier.Text))
            {
                XtraMessageBox.Show("Chưa chọn nhà cung cấp!");
                cbb_Supplier.Focus();
                return;
            }
            if (String.IsNullOrEmpty(cbb_Staff.Text))
            {
                XtraMessageBox.Show("Chưa chọn nhân viên !");
                cbb_Staff.Focus();
                return;
            }
            Username = "admin";
            if (IdEnter != null)
            {
                if(!_enter.IsEnterCoupon(IdEnter))
                {
                    int updateEnter = _enter.UpdateEnterCoupon(txt_ID.Text, cbb_Supplier.SelectedValue.ToString(), cbb_Staff.SelectedValue.ToString(), Username, dtP_DayCreate.Text, CheckReson(), txt_SumMoney.Text);
                    if(updateEnter == 1)
                    {
                        for (int i = 0; i < dgV_DetailsCoupon.Rows.Count; i++)
                        {
                            string iditem = dgV_DetailsCoupon.Rows[i].Cells["ID_ITEM"].Value.ToString();
                            string num = dgV_DetailsCoupon.Rows[i].Cells["NUMBER"].Value.ToString();
                            string price = dgV_DetailsCoupon.Rows[i].Cells["PRICE_IN_2"].Value.ToString();
                            string money = dgV_DetailsCoupon.Rows[i].Cells["SUM_MONEY"].Value.ToString();
                            int UpdateDT = _item.UpdateDtEnterCoupon(txt_ID.Text, iditem, num, price, money);
                            if (UpdateDT != 1)
                            {
                                XtraMessageBox.Show("Có lỗi trong lúc cập nhật !");
                                return;
                            }
                        }
                        XtraMessageBox.Show("Cập nhật thành công");
                        return;
                    }
                }       
            }
            if (dgV_DetailsCoupon.Rows.Count != 0)
            {
                //Them phieu nhap
                int addEnter = _enter.InsertEnterCoupon(txt_ID.Text, cbb_Supplier.SelectedValue.ToString(), cbb_Staff.SelectedValue.ToString(), Username, dtP_DayCreate.Text, CheckReson(), txt_SumMoney.Text);
                if (addEnter == 2)
                {
                    //Them chi tiet phieu nhap
                    int check = 0;
                    for (int i = 0; i < dgV_DetailsCoupon.Rows.Count; i++)
                    {
                        string iditem = dgV_DetailsCoupon.Rows[i].Cells["ID_ITEM"].Value.ToString();
                        string num = dgV_DetailsCoupon.Rows[i].Cells["NUMBER"].Value.ToString();
                        string price = dgV_DetailsCoupon.Rows[i].Cells["PRICE_IN_2"].Value.ToString();
                        string money = dgV_DetailsCoupon.Rows[i].Cells["SUM_MONEY"].Value.ToString();
                        int addDtItem = _item.InsertOneDtailItem(txt_ID.Text, iditem, num, price, money);
                        if (addDtItem == 1)
                        {
                            check++;
                        }
                        else
                        {
                            XtraMessageBox.Show("Có lỗi trong lúc tạo phiếu nhập !");
                            return;
                        }
                    }
                    if (check == dgV_DetailsCoupon.Rows.Count)//Đồng nghĩa lúc nào chi tiet phieu nhap da them thanh cong
                    {
                        //Cap nhat so luong kho
                        int count = 0;
                        for (int i = 0; i < dgV_DetailsCoupon.Rows.Count; i++)
                        {
                            string iditem = dgV_DetailsCoupon.Rows[i].Cells["ID_ITEM"].Value.ToString();
                            string num = dgV_DetailsCoupon.Rows[i].Cells["NUMBER"].Value.ToString();
                            int update = _item.UpdateNumberItemTerminal(iditem, num);
                            if (update == 1)
                            {
                                count++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (count == dgV_DetailsCoupon.Rows.Count)
                        {
                            XtraMessageBox.Show("Tạo phiếu nhập và lưu thành công !");
                        }
                    }
                }
                else if (addEnter == 1)
                {
                    XtraMessageBox.Show("Đã tồn tại phiếu nhập này !");
                    //Thì cập nhật lại phiếu nhập
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Thêm thất bại !");
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show("Chưa có mặt hàng nào cần nhập ! Hãy thêm mặt hàng nhập");
                return;
            }
        }
    }
}