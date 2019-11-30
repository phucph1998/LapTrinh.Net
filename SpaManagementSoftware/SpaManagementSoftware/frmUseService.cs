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
using DbSpaContext;
using System.Collections;

namespace SpaManagementSoftware
{
    public partial class frmUseService : DevExpress.XtraEditors.XtraForm
    {
        //CreateControl createCtr = new CreateControl();
        C_Receipt _receipt;
        C_DetailsReceipt _dtreceipt;
        UserManager usr;
        C_Items _item;
        C_Staff _staff;
        C_Unit _unit;
        C_Staff_User _staffUser;
        CustomerManager _cus;
        string idBranch;
        List<int> listIdChair = new List<int>();
        List<ReceiptTemp> _listReceipt = new List<ReceiptTemp>();

        public frmUseService()
        {
            InitializeComponent();
            _staffUser = new C_Staff_User();
            _dtreceipt = new C_DetailsReceipt();
            usr = new UserManager();
            _item = new C_Items();
            _receipt = new C_Receipt();
            _cus = new CustomerManager();
            _unit = new C_Unit();
            _staff = new C_Staff();
            idBranch = _staffUser.GetIdBranch_User(Program.loginForm.NameAccount);//GetId loginForm            
        }
        //Tạo tầng tạo ghế
        //Create FlowLayoutPanel (tầng)
        public FlowLayoutPanel CreateFloor(int numberFloor, Panel panelName)
        {
            //Thêm flowlayoutpanel
            FlowLayoutPanel floor = new FlowLayoutPanel();
            panelName.Controls.Add(floor);
            floor.Name = "flp_floor" + numberFloor;
            floor.Dock = DockStyle.Top;
            floor.AutoSize = true;
            //Thêm tên tầng
            Label nameFloor = new Label();
            nameFloor.Text = "Tầng " + numberFloor;
            nameFloor.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameFloor.ForeColor = System.Drawing.SystemColors.Highlight;
            nameFloor.Name = "lbl_Floor" + numberFloor;
            nameFloor.Dock = DockStyle.Top;
            panelName.Controls.Add(nameFloor);
            return floor;
        }

        //Create Button have chair icon
        public SimpleButton CreateButtonChair(int numberFloor, int numberChair, FlowLayoutPanel nameFloor, ContextMenuStrip nameCMS)
        {
            SimpleButton btnChair = new SimpleButton();
            nameFloor.Controls.Add(btnChair);
            btnChair.AppearancePressed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnChair.AppearancePressed.Options.UseBackColor = true;
            btnChair.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket_black;
            btnChair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnChair.Name = "btnChair" + idBranch + numberFloor + numberChair;
            btnChair.Size = new System.Drawing.Size(100, 100);
            btnChair.Text = "Ghế " + idBranch + numberFloor + numberChair;
            btnChair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //btnChair.Dock = DockStyle.Left;
            btnChair.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnChair.ForeColor = Color.Black;
            btnChair.DoubleClick += btnChair_DoubleClick;
            btnChair.Click += BtnChair_Click;
            btnChair.Leave += BtnChair_Leave;
            btnChair.Tag = "Close";
            btnChair.ContextMenuStrip = nameCMS;
            return btnChair;
        }

        private void BtnChair_Leave(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            btn.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = Color.Black;
        }

        private void BtnChair_Click(object sender, EventArgs e)
        {
            lbl_NameChair.Text = (sender as SimpleButton).Text;
            SimpleButton btn = (SimpleButton)sender;
            btn.ForeColor = System.Drawing.SystemColors.Highlight;
            txt_Number.Clear();
            txt_NameCus.Clear();
            dgv_DetailReceipt.Rows.Clear();
            string idChair = lbl_NameChair.Text.Substring(lbl_NameChair.Text.Length - 3, 3);
            //Kiem tra neu ghe dang mo thi cac button tuong ung se mo va load du lieu tuong ung
            if (CheckChairOpen("btnChair" + idChair))
            {
                ChairOpen_EnableControls();
                for (int i = 0; i < _listReceipt.Count; i++)
                {
                    if (_listReceipt[i].Chair.Equals(idChair))
                    {
                        //Load hoa don
                        txt_Number.Text = _listReceipt[i].Id;
                        Receipt temp = _receipt.GetReceipt(_listReceipt[i].Id);
                        txt_NameCus.Text = _cus.GetNameCus(temp.IDACCOUNT.ToString());

                        //Load chi tiet hoa don tuong ung
                        DataTable listDt = _dtreceipt.GetDTReceipt(_listReceipt[i].Id);
                        for (int j = 0; j < listDt.Rows.Count; j++)
                        {
                            string idItem = listDt.Rows[j][2].ToString(); ;
                            string product = _item.GetNameItem(listDt.Rows[j][2].ToString());//Lay ten san pham
                            string unit = _unit.GetNameUnit(_item.GetIdUnit(listDt.Rows[j][2].ToString()));//Lay ten don vi
                            string price = listDt.Rows[j][5].ToString();
                            string idStaff = listDt.Rows[j][1].ToString();
                            string nameStaff = _staff.GetNameStaff(listDt.Rows[j][1].ToString());//Lay ten nhan vien
                            string num = listDt.Rows[j][4].ToString(); ;
                            string saleoff = listDt.Rows[j][3].ToString();
                            string total = listDt.Rows[j][6].ToString();
                            string[] row = new string[] { idItem, product, unit, num, price, saleoff, total, idStaff, nameStaff };
                            dgv_DetailReceipt.Rows.Add(row);
                        }
                        break;
                    }
                }
                //Tinh tien lai
                SumMoney();
            }
            else
            {
                ChairClose_EnableControls();
                txt_IntoMoney.Text = "0";
                txt_Sale.Text = "0";
                txt_MoneySale.Text = (float.Parse(txt_IntoMoney.Text) * (float.Parse(txt_Sale.Text) / 100)).ToString();
                txt_Total.Text = (float.Parse(txt_IntoMoney.Text) - float.Parse(txt_MoneySale.Text)).ToString();
            }
            //nguoc lai neu ghe dang dong thi cac button tuong ung se dong
        }

        public void ChairOpen_EnableControls()
        {
            btn_SerchCus.Enabled = true;
            dGV_Item.Enabled = true;
            btn_AddItem.Enabled = true;
            btn_RemoveItem.Enabled = true;
            btn_DeleteItem.Enabled = true;
            btn_Pay.Enabled = true;
            tsbDTReceipt.Enabled = true;
            dgv_DetailReceipt.Enabled = true;
        }

        public void ChairClose_EnableControls()
        {
            btn_SerchCus.Enabled = false;
            dGV_Item.Enabled = false;
            btn_AddItem.Enabled = false;
            btn_RemoveItem.Enabled = false;
            btn_DeleteItem.Enabled = false;
            btn_Pay.Enabled = false;
            tsbDTReceipt.Enabled = false;
            dgv_DetailReceipt.Enabled = false;
        }

        //Sự kiện hiện form thanh toán
        void btnChair_DoubleClick(object sender, EventArgs e)
        {
            /*DialogResult r;
            r = DevExpress.XtraEditors.XtraMessageBox.Show("Tạo Form Tính Tiền", "Nhắc Nhở", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            DevExpress.XtraEditors.SimpleButton t;
            if (r == DialogResult.Yes)
            {
                if (sender.GetType() == typeof(DevExpress.XtraEditors.SimpleButton))
                {
                    t = (DevExpress.XtraEditors.SimpleButton)sender;
                    t.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket;
                }
            }
            else
            {
                t = (DevExpress.XtraEditors.SimpleButton)sender;
                t.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket_black;
            }*/
            SimpleButton t;
            if (sender.GetType() == typeof(SimpleButton))
            {
                t = (SimpleButton)sender;
                if (t.Tag == "Close")
                {
                    MessageBox.Show("Đã mở ghế, Hãy chọn khách hàng để bắt đầu sử dụng dịch vụ !");
                    t.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket;
                    t.Tag = "Open";
                    ChairOpen_EnableControls();
                    //Chon khach hang hoac load lai du lieu ở sự kiện click của button tìm kiếm
                    //Lúc này các button tương ứng sẽ Enable = true
                    return;
                }
                if (t.Tag == "Open")
                {
                    frmPayMent frm = new frmPayMent();
                    frm.IdReceipt = txt_Number.Text;
                    frm.NameChair = lbl_NameChair.Text;
                    frm.ShowDialog();
                    if(frm.flagPayment)
                    {
                        //MessageBox.Show("Dong ghe tinh tien");
                        string idChair = lbl_NameChair.Text.Substring(lbl_NameChair.Text.Length - 3, 3);//Id ghe
                        t.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket_black;
                        t.Tag = "Close";
                        //Lúc này các button tương ứng sẽ Enable = fales
                        ChairClose_EnableControls();
                        //Xóa dữ liệu tạm trong _listReceipt
                        for (int i = 0; i < _listReceipt.Count; i++)
                        {
                            if (_listReceipt[i].Chair.Equals(idChair))
                            {
                                _listReceipt.RemoveAt(i);
                                txt_Number.Clear();
                                break;
                            }
                        }
                        txt_Number.Clear();
                        txt_NameCus.Clear();
                        dgv_DetailReceipt.Rows.Clear();
                        return;
                    }                    
                }
            }
        }

        //Ẩn hiện cột mặt hàng
        private void btn_Hide_Show_Click(object sender, EventArgs e)
        {
            //Kiểm tra lúc này nếu cột cuối ẩn đi thị hiện trở lại. đồng thời thay đổi trạng thái nút button Ẩn/Hiện
            if (tBL_UseService.ColumnStyles[3].Width.ToString().Equals("0"))
            {
                //Hiện lại cột cuối
                tBL_UseService.ColumnStyles[0].Width = 40F;
                tBL_UseService.ColumnStyles[3].Width = 20F;
                this.btn_Hide_Show.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.Next_16x16;
                this.btn_Hide_Show.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
                btn_Hide_Show.Text = "Ẩn";
                btn_AddItem.Visible = true;
                btn_RemoveItem.Visible = true;
                btn_PercentGroup.Visible = true;

            }
            else
            {
                //Ẩn cột cuối
                tBL_UseService.ColumnStyles[0].Width = 60F;
                tBL_UseService.ColumnStyles[3].Width = 0F;
                this.btn_Hide_Show.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.Prev_16x16;
                this.btn_Hide_Show.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
                btn_Hide_Show.Text = "Hiện";
                btn_AddItem.Visible = false;
                btn_RemoveItem.Visible = false;
                btn_PercentGroup.Visible = false;
            }

        }

        public void LoadChairs()
        {
            //i là số tầng của chi nhánh
            //j là số ghế ứng với từng số lầu i của chi nhánh đó

            int nFloor = usr.GetNumberFloorMySQL(Program.loginForm.NameAccount/*"admin"*/);
            for (int i = nFloor; i > 0; i--)
            {
                FlowLayoutPanel temp = new FlowLayoutPanel();
                temp = CreateFloor(i, panel_General);
                int nChair = usr.GetNumberChairMySQL(idBranch + i.ToString());
                for (int j = 1; j <= nChair; j++)
                {
                    CreateButtonChair(i, j, temp, cMS_Menu);
                }
            }
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
            dGV_Item.DataSource = _item.GetTableItemsMySQL_Sale();
        }

        private void frmUseService_Load(object sender, EventArgs e)
        {
            ChairClose_EnableControls();
            LoadChairs();
            LoadTreeGroupItem();
            //Cac button tuong ung se enable = false
        }

        private void tV_GroupItem_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectNode = this.tV_GroupItem.SelectedNode;
            DataTable profileCus = new DataTable();
            if (selectNode.Tag == "1")
            {
                dGV_Item.DataSource = _item.GetTableItemsMySQL_Sale();
            }
            else
            {
                if (selectNode.Tag == "2")
                {
                    dGV_Item.DataSource = _item.GetListItem_ForGroup_Sale(selectNode.Text);
                }
            }
        }

        //Check ghe dang mo
        public bool CheckChairOpen(string btnName)
        {
            foreach (Control item in panel_General.Controls)
            {
                if (item.GetType() == typeof(FlowLayoutPanel))
                {
                    FlowLayoutPanel frame = (FlowLayoutPanel)item;
                    foreach (Control ctr in frame.Controls)
                    {
                        DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)ctr;
                        if (btn.Name == btnName && btn.Tag == "Open")
                            return true;//Ghe dang mo
                    }
                }
            }
            return false;
        }

        public void SumMoney()
        {
            float sum = 0;
            if (dgv_DetailReceipt != null)
            {
                for (int i = 0; i < dgv_DetailReceipt.Rows.Count; i++)
                {
                    sum += float.Parse(dgv_DetailReceipt.Rows[i].Cells["TOTAL"].Value.ToString());
                }
                txt_IntoMoney.Text = sum.ToString();
                txt_MoneySale.Text = (float.Parse(txt_IntoMoney.Text) * (float.Parse(txt_Sale.Text) / 100)).ToString();
                txt_Total.Text = (float.Parse(txt_IntoMoney.Text) - float.Parse(txt_MoneySale.Text)).ToString();
            }
            else
            {
                if (dgv_DetailReceipt.Rows == null)
                {
                    txt_IntoMoney.Text = "0";
                    txt_Sale.Text = "0";
                    txt_MoneySale.Text = (float.Parse(txt_IntoMoney.Text) * (float.Parse(txt_Sale.Text) / 100)).ToString();
                    txt_Total.Text = (float.Parse(txt_IntoMoney.Text) - float.Parse(txt_MoneySale.Text)).ToString();
                }
            }
        }

        private void dGV_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txt_Number.Text.Trim() == string.Empty)
            {
                XtraMessageBox.Show("Vui lòng tìm kiếm khách hàng sử dụng trước !");
                btn_SerchCus.Focus();
                return;
            }
            if (dGV_Item.CurrentRow != null && CheckChairOpen("btnChair" + lbl_NameChair.Text.Substring(lbl_NameChair.Text.Length - 3, 3)))
            {
                frmChooseStaff frm = new frmChooseStaff();
                frm.ShowDialog();
                if (String.IsNullOrEmpty(frm.NameStaff) || String.IsNullOrEmpty(frm.IdStaff))
                {
                    return;
                }
                else
                {
                    string idItem = dGV_Item.CurrentRow.Cells["ID"].Value.ToString();
                    string product = dGV_Item.CurrentRow.Cells["NAME_ITEM"].Value.ToString();
                    string unit = dGV_Item.CurrentRow.Cells["NAME_UNIT"].Value.ToString();
                    string price = dGV_Item.CurrentRow.Cells["PRICE_OUT"].Value.ToString();
                    string idStaff = frm.IdStaff;
                    string nameStaff = frm.NameStaff;
                    string num = cbbNumber.Text;
                    string saleoff = "0";
                    string total = (double.Parse(num) * double.Parse(price) - (double.Parse(num) * double.Parse(price)) * double.Parse(saleoff)).ToString();

                    for (int i = 0; i < dgv_DetailReceipt.Rows.Count; i++)
                    {
                        if (dgv_DetailReceipt.Rows[i].Cells["ID_ITEM"].Value.ToString().Equals(idItem))
                        {
                            float sl = float.Parse(dgv_DetailReceipt.Rows[i].Cells["NUMBER"].Value.ToString());
                            float dg = float.Parse(dgv_DetailReceipt.Rows[i].Cells["PRICEOUT"].Value.ToString());
                            dgv_DetailReceipt.Rows[i].Cells["NUMBER"].Value = (sl + 1).ToString();
                            dgv_DetailReceipt.Rows[i].Cells["TOTAL"].Value = ((sl + 1) * dg).ToString();
                            //Cập nhật chi tiết hóa đơn
                            bool flagUpdate = _dtreceipt.UpdateDetailReceipt(txt_Number.Text, idStaff, idItem, saleoff, dgv_DetailReceipt.Rows[i].Cells["NUMBER"].Value.ToString(), price, dgv_DetailReceipt.Rows[i].Cells["TOTAL"].Value.ToString(), "1");
                            if (flagUpdate)
                            {
                                //cập nhật tổng tiền bên hóa đơn,
                                SumMoney();
                                bool flagUpdateReceiptMoney = _receipt.UpdateToTalReceipt(txt_Number.Text, txt_Total.Text);
                                if (flagUpdateReceiptMoney)
                                {
                                    //cập nhật số lượng kho
                                    return;
                                }
                                else
                                {
                                    XtraMessageBox.Show("Có lỗi !");
                                    return;
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Có lỗi !");
                                return;
                            }
                        }
                    }

                    string[] row = new string[] { idItem, product, unit, num, price, saleoff, total, idStaff, nameStaff };
                    dgv_DetailReceipt.Rows.Add(row);
                    //Thêm 1 chi tiết hóa đơn mới
                    bool flagAdd = _dtreceipt.AddDetailReceipt(txt_Number.Text, idStaff, idItem, saleoff, num, price, total, "1");
                    if (flagAdd)
                    {
                        //cập nhật tổng tiền bên hóa đơn,
                        SumMoney();
                        bool flagUpdateReceiptMoney = _receipt.UpdateToTalReceipt(txt_Number.Text, txt_Total.Text);
                        if (flagUpdateReceiptMoney)
                        {
                            //cập nhật số lượng kho
                            XtraMessageBox.Show("Thêm dịch vụ thành công !", "Thông báo !");
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Có lỗi !");
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi !");
                        return;
                    }
                }
            }
            else
            {
                XtraMessageBox.Show(lbl_NameChair.Text + "chưa được mở !", "Thông báo");
            }
        }

        private void dgv_DetailReceipt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Sua doi truc tiep trong List (Can chu y lai)
            try
            {
                if (dgv_DetailReceipt.CurrentRow != null && Convert.ToInt32(dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString()) > 0)
                {
                    double num = Convert.ToDouble(dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString());
                    double price = Convert.ToDouble(dgv_DetailReceipt.CurrentRow.Cells["PRICEOUT"].Value.ToString());
                    double sale = Convert.ToDouble(dgv_DetailReceipt.CurrentRow.Cells["SALE_OFF"].Value.ToString());
                    dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value = ((num * price) - (num * price * sale)).ToString();
                    //cập nhật tổng tiền bên hóa đơn,
                    SumMoney();
                    //cập nhật số lượng kho
                }
                else
                {
                    dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value = 1;
                    //cập nhật tổng tiền bên hóa đơn,
                    SumMoney();
                    //cập nhật số lượng kho
                }
            }
            catch
            {
                return;
            }
        }

        private void menuItem_OpenChair_Click(object sender, EventArgs e)
        {

        }

        private void btn_SerchCus_Click(object sender, EventArgs e)
        {
            frmSearchCustomer frm = new frmSearchCustomer();
            frm.ShowDialog();
            if (frm.idCus != null && frm.nameCus != null)
            {
                string idhd = (int.Parse(_receipt.CountIdReceipt()) + 1).ToString();
                string idAccount = frm.idCus; //idAccount lấy được sau khi chọn khách hàng                
                string idUser = Program.loginForm.NameAccount;//Sau khi chọn khách hàng tạo hóa đơn rỗng idUser = UserName
                string idChair = lbl_NameChair.Text.Substring(lbl_NameChair.Text.Length - 3, 3);//Lấy được mã ghế ví dụ 111,121,...
                string dateUse = dtp_Date.Text;//Lấy ngày tạo ,ngày sử dụng là ngày hiện tại từ DateTimePicker
                string dateCre = dtp_Date.Text;
                string type = "1";
                //IdChair lay du lieu tu lbl có id ghế. bằng cách dùng hàm CheckChairOpen(string name) đã viết
                //Id khách hàng
                //SaveReceiptEmpty(pIdReceipt,pIdChair,pIdUser,pidAccount,pCreateDate,pDateUse,pType)
                txt_NameCus.Text = frm.nameCus;
                try
                {
                    bool flag = _receipt.CreateReceipt(idhd, idChair, idUser, idAccount, dateCre, dateUse, type);
                    //Lưu mã hóa đơn vào danh sách tạm
                    ReceiptTemp t = new ReceiptTemp();
                    t.Id = idhd;
                    t.Chair = idChair;
                    _listReceipt.Add(t);
                    txt_Number.Text = idhd;
                    XtraMessageBox.Show("Tạo hóa đơn khách hàng thành công !");
                }
                catch
                {
                    XtraMessageBox.Show("Có lỗi khi chọn khách hàng ! Hãy xem lại !", "Thông báo !");
                    return;
                }

            }
        }

        private void tSB_IncreaseItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DetailReceipt.CurrentRow != null)
                {
                    string idItem = dgv_DetailReceipt.CurrentRow.Cells["ID_ITEM"].Value.ToString();
                    float price = float.Parse(dgv_DetailReceipt.CurrentRow.Cells["PRICEOUT"].Value.ToString());
                    string idStaff = dgv_DetailReceipt.CurrentRow.Cells["ID_STAFF"].Value.ToString();
                    int num = int.Parse(dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString());
                    float saleoff = float.Parse(dgv_DetailReceipt.CurrentRow.Cells["SALE_OFF"].Value.ToString());
                    string total = dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value.ToString();

                    int updateNum = num + 1;
                    dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value = updateNum.ToString();
                    dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value = (updateNum * price - updateNum * price * saleoff).ToString();
                    //Cập nhật chi tiết hóa đơn 
                    bool flagUpdate = _dtreceipt.UpdateDetailReceipt(txt_Number.Text, idStaff, idItem, saleoff.ToString(), dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString(), price.ToString(), dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value.ToString(), "1");
                    if (flagUpdate)
                    {
                        //cập nhật tổng tiền bên hóa đơn,
                        SumMoney();
                        bool flagUpdateReceiptMoney = _receipt.UpdateToTalReceipt(txt_Number.Text, txt_Total.Text);
                        if (flagUpdateReceiptMoney)
                        {
                            //cập nhật số lượng kho
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Có lỗi !");
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi tăng số lượng sản phẩm !");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void tSP_ReduceItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DetailReceipt.CurrentRow != null)
                {
                    string idItem = dgv_DetailReceipt.CurrentRow.Cells["ID_ITEM"].Value.ToString();
                    float price = float.Parse(dgv_DetailReceipt.CurrentRow.Cells["PRICEOUT"].Value.ToString());
                    string idStaff = dgv_DetailReceipt.CurrentRow.Cells["ID_STAFF"].Value.ToString();
                    int num = int.Parse(dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString());
                    float saleoff = float.Parse(dgv_DetailReceipt.CurrentRow.Cells["SALE_OFF"].Value.ToString());
                    string total = dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value.ToString();
                    if (num == 0)
                    {
                        return;
                    }
                    int updateNum = num - 1;
                    dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value = updateNum.ToString();
                    dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value = (updateNum * price - updateNum * price * saleoff).ToString();
                    //Cập nhật chi tiết hóa đơn
                    bool flagUpdate = _dtreceipt.UpdateDetailReceipt(txt_Number.Text, idStaff, idItem, saleoff.ToString(), dgv_DetailReceipt.CurrentRow.Cells["NUMBER"].Value.ToString(), price.ToString(), dgv_DetailReceipt.CurrentRow.Cells["TOTAL"].Value.ToString(), "1");
                    if (flagUpdate)
                    {
                        //cập nhật tổng tiền bên hóa đơn
                        SumMoney();
                        bool flagUpdateReceiptMoney = _receipt.UpdateToTalReceipt(txt_Number.Text, txt_Total.Text);
                        if (flagUpdateReceiptMoney)
                        {
                            //cập nhật số lượng kho
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Có lỗi !");
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi giảm số lượng sản phẩm !");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_DetailReceipt.CurrentRow != null)
                {
                    string idItem = dgv_DetailReceipt.CurrentRow.Cells["ID_ITEM"].Value.ToString();
                    string idStaff = dgv_DetailReceipt.CurrentRow.Cells["ID_STAFF"].Value.ToString();
                    //Xóa chi tiết hóa đơn
                    bool flagDelete = _dtreceipt.DeleteDetailReceipt(txt_Number.Text, idStaff, idItem);
                    if (flagDelete)
                    {
                        XtraMessageBox.Show("Đã xóa mặt hàng (dịch vụ)" + dgv_DetailReceipt.CurrentRow.Cells["NAME"].Value.ToString() + " khỏi hóa đơn này !");
                        //cập nhật tổng tiền bên hóa đơn                        
                        dgv_DetailReceipt.Rows.Remove(dgv_DetailReceipt.CurrentRow);
                        SumMoney();
                        bool flagUpdateReceiptMoney = _receipt.UpdateToTalReceipt(txt_Number.Text, txt_Total.Text);
                        if (flagUpdateReceiptMoney)
                        {
                            //cập nhật số lượng kho
                            return;
                        }
                        else
                        {
                            XtraMessageBox.Show("Có lỗi !");
                            return;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Có lỗi khi xóa sản phẩm !");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void txt_Sale_TextChanged(object sender, EventArgs e)
        {
            if (txt_Sale.Text.Trim() != string.Empty)
            {
                txt_MoneySale.Text = (float.Parse(txt_IntoMoney.Text) * (float.Parse(txt_Sale.Text) / 100)).ToString();
                txt_Total.Text = (float.Parse(txt_IntoMoney.Text) - float.Parse(txt_MoneySale.Text)).ToString();
            }
        }

        private void txt_Sale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Sale_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Sale.Text.Trim() == string.Empty)
            {
                txt_Sale.Text = "0";
            }
        }
    }
}