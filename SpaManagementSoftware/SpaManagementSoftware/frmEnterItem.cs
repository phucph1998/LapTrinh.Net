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
    public partial class frmEnterItem : DevExpress.XtraEditors.XtraForm
    {
        public frmEnterItem()
        {
            InitializeComponent();
        }

        private void frmEnterItem_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddCoupon_Click(object sender, EventArgs e)
        {
            frmAddEnterCoupon frm = new frmAddEnterCoupon();
            frm.ShowDialog();
        }
    }
}