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
            try
            {
                dgV_EnterCoupon.DataSource = _enter.LoadListEnter();
                dgV_DetailCoupon.DataSource = _item.GetListItem_IdEnter(dgV_EnterCoupon.Rows[0].Cells["ID"].Value.ToString());
                SumMoney();
            }
            catch
            {
                return;
            }
        }

        private void frmEnterItem_Load(object sender, EventArgs e)
        {
            LoadListEnter();
        }

        private void btn_AddCoupon_Click(object sender, EventArgs e)
        {
            frmAddEnterCoupon frm = new frmAddEnterCoupon();
            frm.ShowDialog();
            LoadListEnter();

        }
        public void SumMoney()
        {
            float sum = 0;
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                for (int i = 0; i < dgV_DetailCoupon.Rows.Count; i++)
                {
                    sum += float.Parse(dgV_DetailCoupon.Rows[i].Cells["INTO_MONEY"].Value.ToString());
                }
            }
            lblSumMoney.Text = String.Format("{0:#,##0.##}", sum);
        }
        private void dgV_EnterCoupon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                dgV_DetailCoupon.DataSource = _item.GetListItem_IdEnter(dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString());
                SumMoney();
            }
        }

        private void dgV_EnterCoupon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                frmAddEnterCoupon frm = new frmAddEnterCoupon();
                frm._idEnter = dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                LoadListEnter();
            }
        }

        private void btn_EditCoupon_Click(object sender, EventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                frmAddEnterCoupon frm = new frmAddEnterCoupon();
                frm._idEnter = dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString();
                frm.ShowDialog();
                LoadListEnter();
            }
        }

        public void FillterEnter()
        {
            DateTime start = Convert.ToDateTime(dtP_Start.Text);
            DateTime end = Convert.ToDateTime(dtP_End.Text);
            if (DateTime.Compare(start, end) < 0 || DateTime.Compare(start, end) == 0)
            {
                if (txt_Supplier.Text.Trim() != string.Empty)
                {
                    //nho hon 0: start som hon end
                    dgV_EnterCoupon.DataSource = _enter.FillterEnterCoupon(start.ToString("yyyy-MM-dd"), end.ToString("yyyy-MM-dd"), txt_Supplier.Text);
                    if (dgV_EnterCoupon.Rows.Count != 0)
                    {
                        dgV_DetailCoupon.DataSource = _item.GetListItem_IdEnter(dgV_EnterCoupon.Rows[0].Cells["ID"].Value.ToString());
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa nhập tên nhà cung cấp !");
                    txt_Supplier.Focus();
                    return;
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn ngày bắt đầu xóm hơn ngày kết thúc !");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            FillterEnter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListEnter();
        }

        private void btn_DeleteCoupon_Click(object sender, EventArgs e)
        {
            if (dgV_EnterCoupon.CurrentRow != null)
            {
                DialogResult r;
                string noti = "Bạn có chắc muốn xóa phiếu nhập ngày " + dgV_EnterCoupon.CurrentRow.Cells["CREATE_DATE"].Value.ToString() + ", Số phiếu:" + dgV_EnterCoupon.CurrentRow.Cells["ID"].Value.ToString();
                r = XtraMessageBox.Show(noti, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    bool deleteEnter = _enter.DeleteEnterCoupon(dgV_DetailCoupon.CurrentRow.Cells["ID_ENTER_COUPON"].Value.ToString());
                    bool flag = true;
                    for (int i = 0; i < dgV_DetailCoupon.Rows.Count; i++)
                    {
                        bool deleteDt = _item.DeleteDtEnterCoupon(dgV_DetailCoupon.Rows[i].Cells["ID_ENTER_COUPON"].Value.ToString(), dgV_DetailCoupon.Rows[i].Cells["ID_ITEM"].Value.ToString());
                        if (!deleteDt)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (deleteEnter && flag)
                    {
                        XtraMessageBox.Show("Xóa phiếu nhập thành công !");
                        LoadListEnter();
                    }
                }
            }
        }
    }
}