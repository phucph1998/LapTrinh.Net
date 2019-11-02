namespace SpaManagementSoftware
{
    partial class frmAddSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tP_Main = new System.Windows.Forms.TabPage();
            this.txt_TaxCode = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_Group = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tP_Extra = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.errPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tP_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 55);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SpaManagementSoftware.Properties.Resources.icons8_supplier_100;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhà cung cấp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tP_Main);
            this.tabControl1.Controls.Add(this.tP_Extra);
            this.tabControl1.Location = new System.Drawing.Point(12, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 243);
            this.tabControl1.TabIndex = 1;
            // 
            // tP_Main
            // 
            this.tP_Main.Controls.Add(this.txt_TaxCode);
            this.tP_Main.Controls.Add(this.txt_Email);
            this.tP_Main.Controls.Add(this.txt_Phone);
            this.tP_Main.Controls.Add(this.label8);
            this.tP_Main.Controls.Add(this.label7);
            this.tP_Main.Controls.Add(this.label6);
            this.tP_Main.Controls.Add(this.txt_Address);
            this.tP_Main.Controls.Add(this.label5);
            this.tP_Main.Controls.Add(this.txt_Name);
            this.tP_Main.Controls.Add(this.label4);
            this.tP_Main.Controls.Add(this.label3);
            this.tP_Main.Controls.Add(this.cbb_Group);
            this.tP_Main.Controls.Add(this.txt_ID);
            this.tP_Main.Controls.Add(this.label2);
            this.tP_Main.Location = new System.Drawing.Point(4, 22);
            this.tP_Main.Name = "tP_Main";
            this.tP_Main.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Main.Size = new System.Drawing.Size(438, 217);
            this.tP_Main.TabIndex = 0;
            this.tP_Main.Text = "Thông tin chính";
            this.tP_Main.UseVisualStyleBackColor = true;
            // 
            // txt_TaxCode
            // 
            this.txt_TaxCode.Location = new System.Drawing.Point(105, 177);
            this.txt_TaxCode.Name = "txt_TaxCode";
            this.txt_TaxCode.Size = new System.Drawing.Size(306, 21);
            this.txt_TaxCode.TabIndex = 13;
            this.txt_TaxCode.Leave += new System.EventHandler(this.txt_TaxCode_Leave);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(67, 149);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(344, 21);
            this.txt_Email.TabIndex = 12;
            this.txt_Email.Leave += new System.EventHandler(this.txt_Email_Leave);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(67, 123);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(344, 21);
            this.txt_Phone.TabIndex = 11;
            this.txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Phone_KeyPress);
            this.txt_Phone.Leave += new System.EventHandler(this.txt_Phone_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã Số Kinh Doanh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Điện thoại";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(67, 91);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(344, 21);
            this.txt_Address.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(67, 37);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(344, 21);
            this.txt_Name.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhóm NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên NCC";
            // 
            // cbb_Group
            // 
            this.cbb_Group.FormattingEnabled = true;
            this.cbb_Group.Location = new System.Drawing.Point(67, 64);
            this.cbb_Group.Name = "cbb_Group";
            this.cbb_Group.Size = new System.Drawing.Size(344, 21);
            this.cbb_Group.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(67, 9);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(154, 21);
            this.txt_ID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC";
            // 
            // tP_Extra
            // 
            this.tP_Extra.Location = new System.Drawing.Point(4, 22);
            this.tP_Extra.Name = "tP_Extra";
            this.tP_Extra.Size = new System.Drawing.Size(438, 217);
            this.tP_Extra.TabIndex = 1;
            this.tP_Extra.Text = "Thông tin ĐKKD";
            this.tP_Extra.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(233, 322);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 35);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Ghi dữ liệu";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(344, 322);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 35);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "Thoát";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // errPro
            // 
            this.errPro.ContainerControl = this;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 365);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmAddSupplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tP_Main.ResumeLayout(false);
            this.tP_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tP_Main;
        private System.Windows.Forms.TabPage tP_Extra;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_Group;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TaxCode;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errPro;
    }
}