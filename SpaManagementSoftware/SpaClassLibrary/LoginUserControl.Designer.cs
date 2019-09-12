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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ptb_Banner = new System.Windows.Forms.PictureBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.chk_RemeberPass = new System.Windows.Forms.CheckBox();
            this.chk_LoginAuto = new System.Windows.Forms.CheckBox();
            this.ptb_Logo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.36978F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.12944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.998431F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.12944F));
            this.tableLayoutPanel1.Controls.Add(this.ptb_Banner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_UserName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_UserName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_Password, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.chk_RemeberPass, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.chk_LoginAuto, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ptb_Logo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Login, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 4, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.8729F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.77591F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.17751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.98061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.00077F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 222);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ptb_Banner
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ptb_Banner, 5);
            this.ptb_Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Banner.Image = global::SpaClassLibrary.Properties.Resources.Banner;
            this.ptb_Banner.Location = new System.Drawing.Point(3, 3);
            this.ptb_Banner.Name = "ptb_Banner";
            this.ptb_Banner.Size = new System.Drawing.Size(456, 73);
            this.ptb_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Banner.TabIndex = 6;
            this.ptb_Banner.TabStop = false;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(134, 79);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(97, 26);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "Người dùng:";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(134, 105);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(97, 29);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Mật khẩu:";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_UserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_UserName, 3);
            this.txt_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_UserName.Location = new System.Drawing.Point(237, 82);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(222, 20);
            this.txt_UserName.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Password, 3);
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Password.Location = new System.Drawing.Point(237, 108);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(222, 20);
            this.txt_Password.TabIndex = 8;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // chk_RemeberPass
            // 
            this.chk_RemeberPass.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chk_RemeberPass, 3);
            this.chk_RemeberPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.chk_RemeberPass.Location = new System.Drawing.Point(237, 137);
            this.chk_RemeberPass.Name = "chk_RemeberPass";
            this.chk_RemeberPass.Size = new System.Drawing.Size(222, 17);
            this.chk_RemeberPass.TabIndex = 9;
            this.chk_RemeberPass.Text = "Ghi nhớ mặt khẩu";
            this.chk_RemeberPass.UseVisualStyleBackColor = true;
            // 
            // chk_LoginAuto
            // 
            this.chk_LoginAuto.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chk_LoginAuto, 3);
            this.chk_LoginAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.chk_LoginAuto.Location = new System.Drawing.Point(237, 164);
            this.chk_LoginAuto.Name = "chk_LoginAuto";
            this.chk_LoginAuto.Size = new System.Drawing.Size(222, 17);
            this.chk_LoginAuto.TabIndex = 10;
            this.chk_LoginAuto.Text = "Tự động đăng nhập";
            this.chk_LoginAuto.UseVisualStyleBackColor = true;
            // 
            // ptb_Logo
            // 
            this.ptb_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_Logo.Image = global::SpaClassLibrary.Properties.Resources.Logo;
            this.ptb_Logo.Location = new System.Drawing.Point(3, 82);
            this.ptb_Logo.Name = "ptb_Logo";
            this.tableLayoutPanel1.SetRowSpan(this.ptb_Logo, 4);
            this.ptb_Logo.Size = new System.Drawing.Size(125, 102);
            this.ptb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptb_Logo.TabIndex = 11;
            this.ptb_Logo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cơ Sở Dữ Liệu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Login
            // 
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Login.Location = new System.Drawing.Point(237, 190);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(100, 23);
            this.btn_Login.TabIndex = 13;
            this.btn_Login.Text = "Đăng Nhập";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cancel.Location = new System.Drawing.Point(356, 190);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(103, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(462, 222);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox ptb_Banner;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.CheckBox chk_RemeberPass;
        private System.Windows.Forms.CheckBox chk_LoginAuto;
        private System.Windows.Forms.PictureBox ptb_Logo;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
    }
}
