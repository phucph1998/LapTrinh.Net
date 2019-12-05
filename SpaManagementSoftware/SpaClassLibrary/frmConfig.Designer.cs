namespace SpaClassLibrary
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ServerName = new System.Windows.Forms.ComboBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_SaveConfig = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_Database = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbb_ServerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_UserName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_Password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_SaveConfig, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbb_Database, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Port, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.50453F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.81568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.32336F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.30799F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.81568F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80031F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.43245F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 4);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(421, 45);
            this.label5.TabIndex = 8;
            this.label5.Text = "CẤU HÌNH CƠ SỞ DỮ LIỆU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_ServerName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbb_ServerName, 3);
            this.cbb_ServerName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbb_ServerName.FormattingEnabled = true;
            this.cbb_ServerName.Location = new System.Drawing.Point(109, 48);
            this.cbb_ServerName.Name = "cbb_ServerName";
            this.cbb_ServerName.Size = new System.Drawing.Size(315, 21);
            this.cbb_ServerName.TabIndex = 1;
            this.cbb_ServerName.DropDown += new System.EventHandler(this.cbb_ServerName_DropDown);
            // 
            // txt_UserName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_UserName, 3);
            this.txt_UserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_UserName.Location = new System.Drawing.Point(109, 72);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(315, 21);
            this.txt_UserName.TabIndex = 2;
            this.txt_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UserName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "User ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Password
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Password, 3);
            this.txt_Password.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Password.Location = new System.Drawing.Point(109, 95);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(315, 21);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // btn_SaveConfig
            // 
            this.btn_SaveConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SaveConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveConfig.ImageOptions.Image")));
            this.btn_SaveConfig.Location = new System.Drawing.Point(134, 171);
            this.btn_SaveConfig.Name = "btn_SaveConfig";
            this.btn_SaveConfig.Size = new System.Drawing.Size(75, 37);
            this.btn_SaveConfig.TabIndex = 3;
            this.btn_SaveConfig.Text = "Lưu Lại";
            this.btn_SaveConfig.Click += new System.EventHandler(this.btn_SaveConfig_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(240, 171);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 37);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cbb_Database
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbb_Database, 3);
            this.cbb_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbb_Database.FormattingEnabled = true;
            this.cbb_Database.Location = new System.Drawing.Point(109, 144);
            this.cbb_Database.Name = "cbb_Database";
            this.cbb_Database.Size = new System.Drawing.Size(315, 21);
            this.cbb_Database.TabIndex = 10;
            this.cbb_Database.DropDown += new System.EventHandler(this.cbb_Database_DropDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Port";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Port
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Port, 3);
            this.txt_Port.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Port.Location = new System.Drawing.Point(109, 120);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(315, 21);
            this.txt_Port.TabIndex = 12;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 211);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤU HÌNH";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ServerName;
        private System.Windows.Forms.TextBox txt_UserName;
        private DevExpress.XtraEditors.SimpleButton btn_SaveConfig;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox cbb_Database;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Port;
    }
}