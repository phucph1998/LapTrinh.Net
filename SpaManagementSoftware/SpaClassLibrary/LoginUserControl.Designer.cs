namespace SpaClassLibrary
{
    partial class LoginUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_UC = new System.Windows.Forms.TableLayoutPanel();
            this.ptb_Banner = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.chk_RemeberPass = new System.Windows.Forms.CheckBox();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_NameDatabase = new System.Windows.Forms.Label();
            this.tlp_UC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_UC
            // 
            this.tlp_UC.ColumnCount = 5;
            this.tlp_UC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.16063F));
            this.tlp_UC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.20798F));
            this.tlp_UC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.634F));
            this.tlp_UC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.511946F));
            this.tlp_UC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48545F));
            this.tlp_UC.Controls.Add(this.ptb_Banner, 0, 0);
            this.tlp_UC.Controls.Add(this.lbl_UserName, 1, 1);
            this.tlp_UC.Controls.Add(this.lbl_Password, 1, 2);
            this.tlp_UC.Controls.Add(this.txt_UserName, 2, 1);
            this.tlp_UC.Controls.Add(this.txt_Password, 2, 2);
            this.tlp_UC.Controls.Add(this.chk_RemeberPass, 2, 3);
            this.tlp_UC.Controls.Add(this.ptb_Logo, 0, 1);
            this.tlp_UC.Controls.Add(this.lbl_Data, 0, 4);
            this.tlp_UC.Controls.Add(this.btn_Login, 2, 4);
            this.tlp_UC.Controls.Add(this.btn_Cancel, 4, 4);
            this.tlp_UC.Controls.Add(this.lbl_NameDatabase, 1, 4);
            this.tlp_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_UC.Location = new System.Drawing.Point(0, 0);
            this.tlp_UC.Name = "tlp_UC";
            this.tlp_UC.RowCount = 5;
            this.tlp_UC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.85366F));
            this.tlp_UC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17073F));
            this.tlp_UC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14634F));
            this.tlp_UC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.19512F));
            this.tlp_UC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.14634F));
            this.tlp_UC.Size = new System.Drawing.Size(462, 205);
            this.tlp_UC.TabIndex = 3;
            // 
            // ptb_Banner
            // 
            this.tlp_UC.SetColumnSpan(this.ptb_Banner, 5);
            this.ptb_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Banner.Image = global::SpaClassLibrary.Properties.Resources.Banner;
            this.ptb_Banner.Location = new System.Drawing.Point(3, 3);
            this.ptb_Banner.Name = "ptb_Banner";
            this.ptb_Banner.Size = new System.Drawing.Size(456, 88);
            this.ptb_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Banner.TabIndex = 6;
            this.ptb_Banner.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(133, 94);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(96, 27);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "Người dùng:";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(133, 121);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(96, 29);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật khẩu:";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UserName
            // 
            this.tlp_UC.SetColumnSpan(this.txt_UserName, 3);
            this.txt_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_UserName.Location = new System.Drawing.Point(235, 97);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(224, 20);
            this.txt_UserName.TabIndex = 7;
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserName_KeyPress);
            // 
            // txt_Password
            // 
            this.tlp_UC.SetColumnSpan(this.txt_Password, 3);
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Password.Location = new System.Drawing.Point(235, 124);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(224, 20);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // chk_RemeberPass
            // 
            this.chk_RemeberPass.AutoSize = true;
            this.tlp_UC.SetColumnSpan(this.chk_RemeberPass, 2);
            this.chk_RemeberPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.chk_RemeberPass.Location = new System.Drawing.Point(235, 153);
            this.chk_RemeberPass.Name = "chk_RemeberPass";
            this.chk_RemeberPass.Size = new System.Drawing.Size(123, 17);
            this.chk_RemeberPass.TabIndex = 9;
            this.chk_RemeberPass.Text = "Ghi nhớ mặt khẩu";
            this.chk_RemeberPass.UseVisualStyleBackColor = true;
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Logo.Image = global::SpaClassLibrary.Properties.Resources.Logo;
            this.ptb_Logo.Location = new System.Drawing.Point(3, 97);
            this.ptb_Logo.Name = "ptb_Logo";
            this.tlp_UC.SetRowSpan(this.ptb_Logo, 3);
            this.ptb_Logo.Size = new System.Drawing.Size(124, 75);
            this.ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_Logo.TabIndex = 11;
            this.ptb_Logo.TabStop = false;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(3, 175);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(124, 30);
            this.lbl_Data.TabIndex = 12;
            this.lbl_Data.Text = "Cơ Sở Dữ Liệu:";
            this.lbl_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Login.Location = new System.Drawing.Point(235, 178);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(103, 23);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cancel.Location = new System.Drawing.Point(364, 178);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_NameDatabase
            // 
            this.lbl_NameDatabase.AutoSize = true;
            this.lbl_NameDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NameDatabase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NameDatabase.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_NameDatabase.Location = new System.Drawing.Point(133, 175);
            this.lbl_NameDatabase.Name = "lbl_NameDatabase";
            this.lbl_NameDatabase.Size = new System.Drawing.Size(96, 30);
            this.lbl_NameDatabase.TabIndex = 15;
            this.lbl_NameDatabase.Text = "label1";
            this.lbl_NameDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_UC);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(462, 205);
            this.Load += new System.EventHandler(this.LoginUserControl_Load);
            this.tlp_UC.ResumeLayout(false);
            this.tlp_UC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_UC;
        private System.Windows.Forms.PictureBox ptb_Banner;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.CheckBox chk_RemeberPass;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.Label lbl_Data;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Label lbl_NameDatabase;
    }
}
