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
            this.lUC_Login = new SpaClassLibrary.LoginUserControl();
            this.SuspendLayout();
            // 
            // lUC_Login
            // 
            this.lUC_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUC_Login.Location = new System.Drawing.Point(0, 0);
            this.lUC_Login.Name = "lUC_Login";
            this.lUC_Login.Size = new System.Drawing.Size(469, 222);
            this.lUC_Login.TabIndex = 0;
            this.lUC_Login.Click += new System.EventHandler(this.lUC_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 222);
            this.Controls.Add(this.lUC_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.ResumeLayout(false);

        }

        #endregion

        private SpaClassLibrary.LoginUserControl lUC_Login;
    }
}