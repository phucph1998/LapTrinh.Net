using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpaClassLibrary;

namespace SpaManagementSoftware
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        UserManager us;
        public frmMain()
        {
            InitializeComponent();
            us = new UserManager();
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

        public Boolean ToBooleanFromRole(string pRole)
        {
            if (pRole.Equals("1"))
                return true;
            else
                return false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            stt_User.Text = Program.loginForm.NameAccount;//Tên đăng nhập
            stt_NameData.Text = Program.loginForm.NameDatabase;//Tên Database

            //List<string> groupUser = us.GetListIdGroupUser(stt_User.Text);
            List<string> groupUser = us.GetListIdGroupUserMySQL(stt_User.Text);
            foreach (string item in groupUser)
            {
                //DataTable listRole = us.GetListScreen(item);//Danh sách màn hình ứng với từng nhóm ND
                DataTable listRole = us.GetListScreenMySQL(item);
                foreach (DataRow screen in listRole.Rows)
                {
                    //FindMenuRole(menuStrip1.Items, screen[1].ToString(), Convert.ToBoolean(screen[2].ToString()));
                    FindMenuRole(menuStrip1.Items, screen[1].ToString(), ToBooleanFromRole(screen[2].ToString()));
                }
            }
        }

        private void FindMenuRole(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    FindMenuRole(((ToolStripMenuItem)(menu)).DropDownItems, pScreenName, pEnable);
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                }
                else if (string.Equals(pScreenName, menu.Tag))
                {
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }

        private bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                {
                    return true;
                }
                else if (menuItem is ToolStripSeparator)
                {
                    continue;
                }
            }
            return false;
        }

        private void tSBUseService_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmUseService"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này", "Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmUseService use = new frmUseService();
                openForm(use);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Visible = true;
        }

        private void tSBManagementSales_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmCustomer"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này", "Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmCustomer cus = new frmCustomer();
                openForm(cus);
            }
        }

        private void phânNhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmAddUserToGroup"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này", "Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmAddUserToGroup frm = new frmAddUserToGroup();
                openForm(frm);
            }
        }

        private void phânQuyềnNhómNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmRole"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này", "Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmRole frm = new frmRole();
                openForm(frm);
            }
        }

        private void tsmiChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass();
            frm.UserName = this.stt_User.Text;
            frm.ShowDialog();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckExist("frmSupplier"))
            {
                XtraMessageBox.Show("Bạn Đang Sử Dụng Chức Năng Này", "Thông báo");
                //MessageBox.Show("Chức Năng Này Đang Sử Dụng, Không Cần Mở Lại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                frmSupplier frm = new frmSupplier();
                openForm(frm);
            }
        }
    }
}
