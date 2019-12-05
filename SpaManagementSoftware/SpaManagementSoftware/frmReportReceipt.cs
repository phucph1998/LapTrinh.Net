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
using Devart.Data.MySql;
using Devart.Data;
using Microsoft.Reporting.WinForms;

namespace SpaManagementSoftware
{
    public partial class frmReportReceipt : DevExpress.XtraEditors.XtraForm
    {
        string pIdReceipt;
        public frmReportReceipt()
        {
            InitializeComponent();
        }

        public string PIdReceipt
        {
            get
            {
                return pIdReceipt;
            }

            set
            {
                pIdReceipt = value;
            }
        }

        private void frmReportReceipt_Load(object sender, EventArgs e)
        {
            DS_Receipt ds = new DS_Receipt();
            string sql1 = "SELECT ID AS id,ID_CHAIR AS id_chair,ID_USER AS user,CREATE_DATE AS create_date,USE_DATE AS create_use,TOTAL_MONEY AS total FROM receipt r WHERE r.ID = "+PIdReceipt+"";
            string sql2 = "SELECT i.NAME AS name,dt.NUMBER AS number,u.NAME AS unit,dt.PRICE_OUT AS price,dt.INTO_MONEY AS into_money FROM detail_receipt dt,item i,unit_item u WHERE dt.ID_ITEM=i.ID AND i.ID_UNIT=u.ID AND dt.ID_RECEIPT="+PIdReceipt+"";
            MySqlDataAdapter da = new MySqlDataAdapter(sql1, Properties.Settings.Default.DbSpaDataContextConnectionString);
            MySqlDataAdapter da_2 = new MySqlDataAdapter(sql2, Properties.Settings.Default.DbSpaDataContextConnectionString);
            da.Fill(ds, ds.Tables["receipt"].TableName);
            da_2.Fill(ds, ds.Tables["details_receipt"].TableName);

            ReportDataSource rds = new ReportDataSource("receipt", ds.Tables["receipt"]);
            ReportDataSource rds_2 = new ReportDataSource("details_receipt", ds.Tables["details_receipt"]);

            this.rPV_Receipt.LocalReport.DataSources.Clear();
            this.rPV_Receipt.LocalReport.DataSources.Add(rds);
            this.rPV_Receipt.LocalReport.DataSources.Add(rds_2);
            this.rPV_Receipt.LocalReport.Refresh();
            this.rPV_Receipt.RefreshReport();
        }
    }
}