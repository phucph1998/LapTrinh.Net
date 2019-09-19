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
        CreateControl createCtr = new CreateControl();
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

        private void frmUseService_Load(object sender, EventArgs e)
        {
            //i là số tầng của chi nhánh
            //j là số ghế ứng với từng số lầu i của chi nhánh đó
            for (int i = 2; i > 0; i--)
            {
                FlowLayoutPanel temp = new FlowLayoutPanel();
                temp = createCtr.CreateFloor(i, panel_General);
                for (int j = 1; j < 8; j++)
                {
                    createCtr.CreateButtonChair(i, j, temp, cMS_Menu);
                }
            }
        }


    }
}