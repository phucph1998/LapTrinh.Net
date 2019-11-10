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
    public partial class frmEnterItem : DevExpress.XtraEditors.XtraForm
    {
        C_Enter _enter;
        C_Items _item;
        public frmEnterItem()
        {
            InitializeComponent();
            _enter = new C_Enter();
            _item = new C_Items();
        }

        void LoadListEnter()
        {
            dgV_EnterCoupon.DataSource = _enter.LoadListEnter();
            dgV_DetailCoupon.DataSource = _item.GetListItem_IdEnter("1");
        }

        private void frmEnterItem_Load(object sender, EventArgs e)
        {
            LoadListEnter();
        }

        private void btn_AddCoupon_Click(object sender, EventArgs e)
        {
            frmAddEnterCoupon frm = new frmAddEnterCoupon();
            frm.ShowDialog();
        }

        private void dgV_EnterCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                dgV_DetailCoupon.DataSource = _item.GetListItem_IdEnter(dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void dgV_EnterCoupon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                frmAddEnterCoupon frm = new frmAddEnterCoupon();
                frm._idEnter = dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
            }
        }
    }
}