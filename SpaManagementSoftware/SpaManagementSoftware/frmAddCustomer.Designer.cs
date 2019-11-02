namespace SpaManagementSoftware
{
    partial class frmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCustomer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Birthday = new DevExpress.XtraEditors.DateEdit();
            this.txt_IDProfile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TypeCus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.MaskedTextBox();
            this.rbtn_Women = new System.Windows.Forms.RadioButton();
            this.rbtn_Men = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.ptb_ImageCus = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ImportImg = new DevExpress.XtraEditors.SimpleButton();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_SaveImg = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Birthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Birthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ImageCus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Birthday);
            this.groupBox1.Controls.Add(this.txt_IDProfile);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_TypeCus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Phone);
            this.groupBox1.Controls.Add(this.rbtn_Women);
            this.groupBox1.Controls.Add(this.rbtn_Men);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txt_Birthday
            // 
            this.txt_Birthday.EditValue = null;
            this.txt_Birthday.Location = new System.Drawing.Point(380, 33);
            this.txt_Birthday.Name = "txt_Birthday";
            this.txt_Birthday.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Birthday.Properties.Appearance.Options.UseFont = true;
            this.txt_Birthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Birthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Birthday.Size = new System.Drawing.Size(134, 24);
            this.txt_Birthday.TabIndex = 18;
            // 
            // txt_IDProfile
            // 
            this.txt_IDProfile.Enabled = false;
            this.txt_IDProfile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IDProfile.Location = new System.Drawing.Point(120, 33);
            this.txt_IDProfile.Name = "txt_IDProfile";
            this.txt_IDProfile.Size = new System.Drawing.Size(174, 22);
            this.txt_IDProfile.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã KH:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(314, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày Sinh:";
            // 
            // cbb_TypeCus
            // 
            this.cbb_TypeCus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TypeCus.FormattingEnabled = true;
            this.cbb_TypeCus.Location = new System.Drawing.Point(120, 160);
            this.cbb_TypeCus.Name = "cbb_TypeCus";
            this.cbb_TypeCus.Size = new System.Drawing.Size(394, 22);
            this.cbb_TypeCus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Loại KH:";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Location = new System.Drawing.Point(120, 93);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(394, 22);
            this.txt_Address.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số ĐT:";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Location = new System.Drawing.Point(120, 127);
            this.txt_Phone.Mask = "0000000000";
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(205, 22);
            this.txt_Phone.TabIndex = 9;
            // 
            // rbtn_Women
            // 
            this.rbtn_Women.AutoSize = true;
            this.rbtn_Women.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Women.ForeColor = System.Drawing.Color.Black;
            this.rbtn_Women.Location = new System.Drawing.Point(477, 128);
            this.rbtn_Women.Name = "rbtn_Women";
            this.rbtn_Women.Size = new System.Drawing.Size(41, 18);
            this.rbtn_Women.TabIndex = 8;
            this.rbtn_Women.TabStop = true;
            this.rbtn_Women.Text = "Nữ";
            this.rbtn_Women.UseVisualStyleBackColor = true;
            // 
            // rbtn_Men
            // 
            this.rbtn_Men.AutoSize = true;
            this.rbtn_Men.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Men.ForeColor = System.Drawing.Color.Black;
            this.rbtn_Men.Location = new System.Drawing.Point(407, 128);
            this.rbtn_Men.Name = "rbtn_Men";
            this.rbtn_Men.Size = new System.Drawing.Size(49, 18);
            this.rbtn_Men.TabIndex = 7;
            this.rbtn_Men.TabStop = true;
            this.rbtn_Men.Text = "Nam";
            this.rbtn_Men.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(346, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(120, 65);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(394, 22);
            this.txt_Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // btn_Add
            // 
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(419, 265);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 32);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.ImageOptions.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(638, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 32);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(530, 265);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 32);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Cập Nhật";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ptb_ImageCus
            // 
            this.ptb_ImageCus.Location = new System.Drawing.Point(595, 26);
            this.ptb_ImageCus.Name = "ptb_ImageCus";
            this.ptb_ImageCus.Size = new System.Drawing.Size(188, 222);
            this.ptb_ImageCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_ImageCus.TabIndex = 5;
            this.ptb_ImageCus.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(550, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ảnh";
            // 
            // btn_ImportImg
            // 
            this.btn_ImportImg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImportImg.ImageOptions.Image")));
            this.btn_ImportImg.Location = new System.Drawing.Point(553, 48);
            this.btn_ImportImg.Name = "btn_ImportImg";
            this.btn_ImportImg.Size = new System.Drawing.Size(26, 24);
            this.btn_ImportImg.TabIndex = 20;
            this.btn_ImportImg.Click += new System.EventHandler(this.btn_ImportImg_Click);
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // btn_SaveImg
            // 
            this.btn_SaveImg.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_SaveImg.Location = new System.Drawing.Point(553, 77);
            this.btn_SaveImg.Name = "btn_SaveImg";
            this.btn_SaveImg.Size = new System.Drawing.Size(26, 24);
            this.btn_SaveImg.TabIndex = 21;
            this.btn_SaveImg.Click += new System.EventHandler(this.btn_SaveImg_Click);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 308);
            this.Controls.Add(this.btn_SaveImg);
            this.Controls.Add(this.btn_ImportImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ptb_ImageCus);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Birthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Birthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ImageCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_TypeCus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_Phone;
        private System.Windows.Forms.RadioButton rbtn_Women;
        private System.Windows.Forms.RadioButton rbtn_Men;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private System.Windows.Forms.TextBox txt_IDProfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptb_ImageCus;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btn_ImportImg;
        private DevExpress.XtraEditors.DateEdit txt_Birthday;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private DevExpress.XtraEditors.SimpleButton btn_SaveImg;
    }
}