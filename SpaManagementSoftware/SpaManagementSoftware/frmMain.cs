using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SpaManagementSoftware
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public Boolean CheckExist(string frmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        public void openForm(Form frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == frm.GetType())
                {
                    f.Activate();
                    return;
                }

            }
            frm.MdiParent = this;
            frm.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmUseService use = new frmUseService();
            openForm(use);
        }

        private void tSBUseService_Click(object sender, EventArgs e)
        {
            if(CheckExist("frmUseService"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này","Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmUseService use = new frmUseService();
                openForm(use);
            }
        }
    }
}
