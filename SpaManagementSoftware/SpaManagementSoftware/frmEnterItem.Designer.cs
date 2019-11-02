﻿namespace SpaManagementSoftware
{
    partial class frmEnterItem
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_AddCoupon = new System.Windows.Forms.ToolStripButton();
            this.btn_EditCoupon = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteCoupon = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtP_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtP_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgV_EnterCoupon = new System.Windows.Forms.DataGridView();
            this.dgV_DetailCoupon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_EnterCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_DetailCoupon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgV_EnterCoupon, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgV_DetailCoupon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.521472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.91411F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddCoupon,
            this.btn_EditCoupon,
            this.btn_DeleteCoupon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(444, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_AddCoupon
            // 
            this.btn_AddCoupon.Image = global::SpaManagementSoftware.Properties.Resources.add;
            this.btn_AddCoupon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddCoupon.Name = "btn_AddCoupon";
            this.btn_AddCoupon.Size = new System.Drawing.Size(90, 22);
            this.btn_AddCoupon.Text = "Thêm Phiếu";
            this.btn_AddCoupon.Click += new System.EventHandler(this.btn_AddCoupon_Click);
            // 
            // btn_EditCoupon
            // 
            this.btn_EditCoupon.Image = global::SpaManagementSoftware.Properties.Resources.Edit_16x16;
            this.btn_EditCoupon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EditCoupon.Name = "btn_EditCoupon";
            this.btn_EditCoupon.Size = new System.Drawing.Size(79, 22);
            this.btn_EditCoupon.Text = "Sửa phiếu";
            // 
            // btn_DeleteCoupon
            // 
            this.btn_DeleteCoupon.Image = global::SpaManagementSoftware.Properties.Resources.remove;
            this.btn_DeleteCoupon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteCoupon.Name = "btn_DeleteCoupon";
            this.btn_DeleteCoupon.Size = new System.Drawing.Size(80, 22);
            this.btn_DeleteCoupon.Text = "Xóa phiếu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_Supplier);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtP_End);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtP_Start);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 75);
            this.panel1.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.Lookup_Reference_16x16;
            this.btn_Search.Location = new System.Drawing.Point(323, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(27, 23);
            this.btn_Search.TabIndex = 6;
            // 
            // txt_Supplier
            // 
            this.txt_Supplier.Location = new System.Drawing.Point(94, 44);
            this.txt_Supplier.Name = "txt_Supplier";
            this.txt_Supplier.Size = new System.Drawing.Size(218, 21);
            this.txt_Supplier.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // dtP_End
            // 
            this.dtP_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_End.Location = new System.Drawing.Point(203, 14);
            this.dtP_End.Name = "dtP_End";
            this.dtP_End.Size = new System.Drawing.Size(109, 21);
            this.dtP_End.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến:";
            // 
            // dtP_Start
            // 
            this.dtP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_Start.Location = new System.Drawing.Point(42, 14);
            this.dtP_Start.Name = "dtP_Start";
            this.dtP_Start.Size = new System.Drawing.Size(108, 21);
            this.dtP_Start.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ:";
            // 
            // dgV_EnterCoupon
            // 
            this.dgV_EnterCoupon.AllowUserToAddRows = false;
            this.dgV_EnterCoupon.AllowUserToDeleteRows = false;
            this.dgV_EnterCoupon.BackgroundColor = System.Drawing.Color.White;
            this.dgV_EnterCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_EnterCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_EnterCoupon.Location = new System.Drawing.Point(3, 110);
            this.dgV_EnterCoupon.Name = "dgV_EnterCoupon";
            this.dgV_EnterCoupon.ReadOnly = true;
            this.dgV_EnterCoupon.Size = new System.Drawing.Size(438, 376);
            this.dgV_EnterCoupon.TabIndex = 2;
            // 
            // dgV_DetailCoupon
            // 
            this.dgV_DetailCoupon.BackgroundColor = System.Drawing.Color.White;
            this.dgV_DetailCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_DetailCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_DetailCoupon.Location = new System.Drawing.Point(447, 29);
            this.dgV_DetailCoupon.Name = "dgV_DetailCoupon";
            this.tableLayoutPanel1.SetRowSpan(this.dgV_DetailCoupon, 2);
            this.dgV_DetailCoupon.Size = new System.Drawing.Size(439, 457);
            this.dgV_DetailCoupon.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(447, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 20);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(310, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số tiền của phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "TỔNG CỘNG:";
            // 
            // frmEnterItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEnterItem";
            this.Text = "NHẬP KHO";
            this.Load += new System.EventHandler(this.frmEnterItem_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_EnterCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_DetailCoupon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgV_EnterCoupon;
        private System.Windows.Forms.DataGridView dgV_DetailCoupon;
        private System.Windows.Forms.DateTimePicker dtP_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtP_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Supplier;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private System.Windows.Forms.ToolStripButton btn_AddCoupon;
        private System.Windows.Forms.ToolStripButton btn_EditCoupon;
        private System.Windows.Forms.ToolStripButton btn_DeleteCoupon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}