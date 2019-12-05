namespace SpaManagementSoftware
{
    partial class frmReportReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Receipt = new SpaManagementSoftware.DS_Receipt();
            this.details_receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPV_Receipt = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details_receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataMember = "receipt";
            this.receiptBindingSource.DataSource = this.DS_Receipt;
            // 
            // DS_Receipt
            // 
            this.DS_Receipt.DataSetName = "DS_Receipt";
            this.DS_Receipt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // details_receiptBindingSource
            // 
            this.details_receiptBindingSource.DataMember = "details_receipt";
            this.details_receiptBindingSource.DataSource = this.DS_Receipt;
            // 
            // rPV_Receipt
            // 
            this.rPV_Receipt.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "receipt";
            reportDataSource1.Value = this.receiptBindingSource;
            reportDataSource2.Name = "details_receipt";
            reportDataSource2.Value = this.details_receiptBindingSource;
            this.rPV_Receipt.LocalReport.DataSources.Add(reportDataSource1);
            this.rPV_Receipt.LocalReport.DataSources.Add(reportDataSource2);
            this.rPV_Receipt.LocalReport.ReportEmbeddedResource = "SpaManagementSoftware.ReceiptReport.rdlc";
            this.rPV_Receipt.Location = new System.Drawing.Point(0, 0);
            this.rPV_Receipt.Name = "rPV_Receipt";
            this.rPV_Receipt.ServerReport.BearerToken = null;
            this.rPV_Receipt.Size = new System.Drawing.Size(456, 534);
            this.rPV_Receipt.TabIndex = 0;
            // 
            // frmReportReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 534);
            this.Controls.Add(this.rPV_Receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Hóa Đơn";
            this.Load += new System.EventHandler(this.frmReportReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details_receiptBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rPV_Receipt;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private DS_Receipt DS_Receipt;
        private System.Windows.Forms.BindingSource details_receiptBindingSource;
    }
}