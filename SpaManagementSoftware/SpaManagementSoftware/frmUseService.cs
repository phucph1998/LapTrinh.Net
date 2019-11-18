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
    public partial class frmUseService : DevExpress.XtraEditors.XtraForm
    {
        CreateControl createCtr = new CreateControl();
        UserManager usr;
        C_Items _item;
        public frmUseService()
        {
            InitializeComponent();
            usr = new UserManager();
            _item = new C_Items();
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
            int nFloor = usr.GetNumberFloorMySQL(Program.loginForm.NameAccount);
            for (int i = nFloor; i > 0; i--)
            {
                FlowLayoutPanel temp = new FlowLayoutPanel();
                temp = createCtr.CreateFloor(i, panel_General);
                int nChair = usr.GetNumberChairMySQL(i.ToString());
                for (int j = 1; j <= nChair; j++)
                {
                    createCtr.CreateButtonChair(i, j, temp, cMS_Menu);
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
            LoadChairs();
            LoadTreeGroupItem();
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

        private void dGV_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}