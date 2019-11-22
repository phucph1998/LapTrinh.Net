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
    public partial class frmChooseStaff : DevExpress.XtraEditors.XtraForm
    {
        C_Staff _staff;
        String idStaff;
        String nameStaff;

        public string IdStaff
        {
            get
            {
                return idStaff;
            }

            set
            {
                idStaff = value;
            }
        }

        public string NameStaff
        {
            get
            {
                return nameStaff;
            }

            set
            {
                nameStaff = value;
            }
        }

        public frmChooseStaff()
        {
            InitializeComponent();
            _staff = new C_Staff();
        }

        private void frmChooseStaff_Load(object sender, EventArgs e)
        {
            cbbStaff.DataSource = _staff.LoadListStaff_SameBranch(Program.loginForm.NameAccount);
            cbbStaff.DisplayMember = "NAME";
            cbbStaff.ValueMember = "ID";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cbbStaff.Text != null)
            {
                IdStaff = cbbStaff.SelectedValue.ToString();
                NameStaff = cbbStaff.Text;
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}