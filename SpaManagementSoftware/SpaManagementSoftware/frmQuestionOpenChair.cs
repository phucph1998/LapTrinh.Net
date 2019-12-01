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
    public partial class frmQuestionOpenChair : DevExpress.XtraEditors.XtraForm
    {
        bool flagOpen;//false mo ghe binh thuong,true mo ghe tu dat lich

        public bool FlagOpen
        {
            get
            {
                return flagOpen;
            }

            set
            {
                flagOpen = value;
            }
        }

        public frmQuestionOpenChair()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            FlagOpen = false;
            this.Close();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FlagOpen = true;
            this.Close();
        }
    }
}