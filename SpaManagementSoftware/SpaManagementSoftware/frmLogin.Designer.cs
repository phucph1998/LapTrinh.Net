namespace SpaManagementSoftware
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.lUC_Login = new SpaClassLibrary.LoginUserControl();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(360, 189);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 25);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lUC_Login
            // 
            this.lUC_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUC_Login.Location = new System.Drawing.Point(0, 0);
            this.lUC_Login.Name = "lUC_Login";
            this.lUC_Login.Size = new System.Drawing.Size(469, 222);
            this.lUC_Login.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 222);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lUC_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Validated += new System.EventHandler(this.frmLogin_Validated);
            this.ResumeLayout(false);

        }

        #endregion

        private SpaClassLibrary.LoginUserControl lUC_Login;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}