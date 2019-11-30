namespace SpaManagementSoftware
{
    partial class frmPayMent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayMent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Chair = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ToTal = new System.Windows.Forms.TextBox();
            this.txt_MoneyCus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Refund = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_PrintTemp = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CloseBillPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CloseBillNoPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 55);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẠN CÓ MUỐN THANH TOÁN KHÔNG ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpaManagementSoftware.Properties.Resources.ticket;
            this.pictureBox1.Location = new System.Drawing.Point(13, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Chair
            // 
            this.lbl_Chair.AutoSize = true;
            this.lbl_Chair.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Chair.Location = new System.Drawing.Point(122, 74);
            this.lbl_Chair.Name = "lbl_Chair";
            this.lbl_Chair.Size = new System.Drawing.Size(47, 23);
            this.lbl_Chair.TabIndex = 4;
            this.lbl_Chair.Text = "Ghế";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "TỔNG TIỀN";
            // 
            // txt_ToTal
            // 
            this.txt_ToTal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ToTal.BackColor = System.Drawing.Color.Aquamarine;
            this.txt_ToTal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ToTal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ToTal.Location = new System.Drawing.Point(255, 115);
            this.txt_ToTal.Name = "txt_ToTal";
            this.txt_ToTal.Size = new System.Drawing.Size(252, 33);
            this.txt_ToTal.TabIndex = 6;
            // 
            // txt_MoneyCus
            // 
            this.txt_MoneyCus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_MoneyCus.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MoneyCus.Location = new System.Drawing.Point(255, 154);
            this.txt_MoneyCus.Name = "txt_MoneyCus";
            this.txt_MoneyCus.Size = new System.Drawing.Size(252, 33);
            this.txt_MoneyCus.TabIndex = 8;
            this.txt_MoneyCus.TextChanged += new System.EventHandler(this.txt_MoneyCus_TextChanged);
            this.txt_MoneyCus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MoneyCus_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "KHÁCH ĐƯA";
            // 
            // txt_Refund
            // 
            this.txt_Refund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Refund.BackColor = System.Drawing.Color.Aquamarine;
            this.txt_Refund.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Refund.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Refund.Location = new System.Drawing.Point(255, 193);
            this.txt_Refund.Name = "txt_Refund";
            this.txt_Refund.Size = new System.Drawing.Size(252, 33);
            this.txt_Refund.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "TRẢ LẠI";
            // 
            // btn_PrintTemp
            // 
            this.btn_PrintTemp.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PrintTemp.Appearance.Options.UseFont = true;
            this.btn_PrintTemp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_PrintTemp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_PrintTemp.Location = new System.Drawing.Point(376, 73);
            this.btn_PrintTemp.Name = "btn_PrintTemp";
            this.btn_PrintTemp.Size = new System.Drawing.Size(131, 35);
            this.btn_PrintTemp.TabIndex = 11;
            this.btn_PrintTemp.Text = "In tạm tính";
            // 
            // btn_CloseBillPrint
            // 
            this.btn_CloseBillPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseBillPrint.Appearance.Options.UseFont = true;
            this.btn_CloseBillPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_CloseBillPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_CloseBillPrint.Location = new System.Drawing.Point(325, 232);
            this.btn_CloseBillPrint.Name = "btn_CloseBillPrint";
            this.btn_CloseBillPrint.Size = new System.Drawing.Size(182, 35);
            this.btn_CloseBillPrint.TabIndex = 12;
            this.btn_CloseBillPrint.Text = "Đóng bill và In";
            this.btn_CloseBillPrint.Click += new System.EventHandler(this.btn_CloseBillPrint_Click);
            // 
            // btn_CloseBillNoPrint
            // 
            this.btn_CloseBillNoPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseBillNoPrint.Appearance.Options.UseFont = true;
            this.btn_CloseBillNoPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btn_CloseBillNoPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_CloseBillNoPrint.Location = new System.Drawing.Point(325, 273);
            this.btn_CloseBillNoPrint.Name = "btn_CloseBillNoPrint";
            this.btn_CloseBillNoPrint.Size = new System.Drawing.Size(182, 35);
            this.btn_CloseBillNoPrint.TabIndex = 13;
            this.btn_CloseBillNoPrint.Text = "Đóng bill không In";
            this.btn_CloseBillNoPrint.Click += new System.EventHandler(this.btn_CloseBillNoPrint_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btn_Cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_Cancel.Location = new System.Drawing.Point(325, 314);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(182, 35);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Hủy Bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "- Bạn chọn \"Đóng bill và in\" để xác nhận thanh toán, in hóa đơn và đóng ghế.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 39);
            this.label7.TabIndex = 16;
            this.label7.Text = "- Bạn chọn \"Hủy bỏ\" để dùng thao tác.";
            // 
            // frmPayMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 360);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_CloseBillNoPrint);
            this.Controls.Add(this.btn_CloseBillPrint);
            this.Controls.Add(this.btn_PrintTemp);
            this.Controls.Add(this.txt_Refund);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_MoneyCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ToTal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Chair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayMent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận thanh toán";
            this.Load += new System.EventHandler(this.frmPayMent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Chair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ToTal;
        private System.Windows.Forms.TextBox txt_MoneyCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Refund;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_PrintTemp;
        private DevExpress.XtraEditors.SimpleButton btn_CloseBillPrint;
        private DevExpress.XtraEditors.SimpleButton btn_CloseBillNoPrint;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}