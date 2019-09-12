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

namespace SpaManagementSoftware
{
    public partial class frmUseService : DevExpress.XtraEditors.XtraForm
    {
        public frmUseService()
        {
            InitializeComponent();
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
        public SimpleButton CreateButtonChair(int numberFloor, int numberChair, FlowLayoutPanel nameFloor)
        {
            SimpleButton btnChair = new SimpleButton();
            nameFloor.Controls.Add(btnChair);
            btnChair.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.ticket_black;
            btnChair.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            btnChair.Name = "btnChair" + numberFloor + "." + numberChair;
            btnChair.Size = new System.Drawing.Size(100, 80);
            btnChair.Text = "Ghế " + numberFloor + "." + numberChair;
            btnChair.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //btnChair.Dock = DockStyle.Left;
            btnChair.Font = new Font("Tahoma", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            btnChair.ForeColor = Color.Black;
            btnChair.DoubleClick += btnChair_DoubleClick;
            btnChair.ContextMenuStrip = this.cMS_Menu;
            return btnChair;
        }

        //Sự kiện hiện form thanh toán
        void btnChair_DoubleClick(object sender, EventArgs e)
        {
            DialogResult r;
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
            }
        }

        private void frmUseService_Load(object sender, EventArgs e)
        {
            //i là số tầng của chi nhánh
            //j là số ghế ứng với từng số lầu i của chi nhánh đó
            for (int i = 2; i > 0; i--)
            {
                FlowLayoutPanel temp = new FlowLayoutPanel();
                temp = CreateFloor(i, panel_General);
                for (int j = 1; j < 8; j++)
                {
                    CreateButtonChair(i, j, temp);
                }
            }
        }


    }
}