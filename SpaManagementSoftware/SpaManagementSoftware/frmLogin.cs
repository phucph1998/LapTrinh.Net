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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool checkFrm;//Dấu hiệu để frmMain biết là frmLogin có đăng nhập thành công.
        public string nameAccount;
        private string nameDatabase;
        public int numberRole;

        public string NameDatabase
        {
            get { return nameDatabase; }
            set { nameDatabase = value; }
        }

        public string NameAccount
        {
            get { return nameAccount; }
            set { nameAccount = value; }
        }

        public int NumberRole
        {
            get { return numberRole; }
            set { numberRole = value; }
        }

        public bool CheckFrm
        {
            get { return checkFrm; }
            set { checkFrm = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_BackColorChanged(object sender, EventArgs e)
        {
            if (lUC_Login.Flag == true)
            {
                NameAccount = lUC_Login.NameAccount;
                NumberRole = lUC_Login.NumberRole;
                NameDatabase = lUC_Login.NameDatabase;
                if (Program.mainForm == null || Program.mainForm.IsDisposed)
                {
                    Program.mainForm = new frmMain();
                }
                this.Visible = false;
                this.BackColor = System.Drawing.SystemColors.Control;
                Program.mainForm.Show();
            }
        }
    }
}