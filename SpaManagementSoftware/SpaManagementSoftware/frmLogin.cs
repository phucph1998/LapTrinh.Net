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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static int Access;
        public frmLogin()
        {
            InitializeComponent();
            Access = 0;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = XtraMessageBox.Show("Bạn có chắc muốn thoát ?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(r == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void frmLogin_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        } 
    }
}