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
    public partial class frmAddGroupItems : DevExpress.XtraEditors.XtraForm
    {
        C_GroupItem _groupitem;
        String nameGroup;

        public string NameGroup
        {
            get
            {
                return nameGroup;
            }

            set
            {
                nameGroup = value;
            }
        }

        public frmAddGroupItems()
        {
            InitializeComponent();
            _groupitem = new C_GroupItem();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (NameGroup != null)
            {
                //Cap nhat
                bool update = _groupitem.UpdateGroupItem(NameGroup, txt_NameGroup.Text);
                if (update)
                {
                    XtraMessageBox.Show("Bạn đã cập nhật thành công !");
                    this.Close();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Cập nhật thất bại !");
                    this.Close();
                    return;
                }
            }
            else
            {
                //Them
                if (String.IsNullOrEmpty(txt_NameGroup.Text))
                {
                    XtraMessageBox.Show("Bạn chưa nhập tên nhóm !");
                    txt_NameGroup.Focus();
                    return;
                }
                bool add = _groupitem.AddGroupItem(txt_NameGroup.Text);
                if (add)
                {
                    XtraMessageBox.Show("Bạn vừa thêm một nhóm mới !");
                    this.Close();
                    return;
                }
                else
                {
                    XtraMessageBox.Show("Ghi dữ liệu thất bại!");
                    this.Close();
                    return;
                }
            }
        }

        private void frmAddGroupItems_Load(object sender, EventArgs e)
        {
            if (NameGroup != null)
            {
                txt_NameGroup.Text = NameGroup;
            }
        }
    }
}