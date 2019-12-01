namespace SpaManagementSoftware
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            this.dtP_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtP_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Receipt = new System.Windows.Forms.DataGridView();
            this.CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CHAIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_CUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ACCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_DetailReceipt = new System.Windows.Forms.DataGridView();
            this.ID_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEUNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICEOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALE_OFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_STAFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_STAFF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // dtP_End
            // 
            this.dtP_End.CustomFormat = "dd/MM/yyyy";
            this.dtP_End.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtP_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_End.Location = new System.Drawing.Point(209, 13);
            this.dtP_End.Name = "dtP_End";
            this.dtP_End.Size = new System.Drawing.Size(109, 23);
            this.dtP_End.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến:";
            // 
            // dtP_Start
            // 
            this.dtP_Start.CustomFormat = "dd/MM/yyyy";
            this.dtP_Start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtP_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtP_Start.Location = new System.Drawing.Point(48, 13);
            this.dtP_Start.Name = "dtP_Start";
            this.dtP_Start.Size = new System.Drawing.Size(108, 23);
            this.dtP_Start.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ:";
            // 
            // dgv_Receipt
            // 
            this.dgv_Receipt.AllowUserToAddRows = false;
            this.dgv_Receipt.AllowUserToDeleteRows = false;
            this.dgv_Receipt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Receipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREATE_DATE,
            this.ID,
            this.ID_CHAIR,
            this.NAME_CUS,
            this.ADDRESS,
            this.PHONE,
            this.ID_ACCOUNT});
            this.dgv_Receipt.Location = new System.Drawing.Point(14, 52);
            this.dgv_Receipt.Name = "dgv_Receipt";
            this.dgv_Receipt.ReadOnly = true;
            this.dgv_Receipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Receipt.Size = new System.Drawing.Size(413, 368);
            this.dgv_Receipt.TabIndex = 8;
            this.dgv_Receipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Receipt_CellClick);
            // 
            // CREATE_DATE
            // 
            this.CREATE_DATE.DataPropertyName = "CREATE_DATE";
            this.CREATE_DATE.HeaderText = "Ngày đặt";
            this.CREATE_DATE.Name = "CREATE_DATE";
            this.CREATE_DATE.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Số Phiếu";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ID_CHAIR
            // 
            this.ID_CHAIR.DataPropertyName = "ID_CHAIR";
            this.ID_CHAIR.HeaderText = "Số Ghế";
            this.ID_CHAIR.Name = "ID_CHAIR";
            this.ID_CHAIR.ReadOnly = true;
            // 
            // NAME_CUS
            // 
            this.NAME_CUS.DataPropertyName = "NAME_CUS";
            this.NAME_CUS.HeaderText = "Người đặt";
            this.NAME_CUS.Name = "NAME_CUS";
            this.NAME_CUS.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa chỉ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Điện thoại";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // ID_ACCOUNT
            // 
            this.ID_ACCOUNT.DataPropertyName = "ID_ACCOUNT";
            this.ID_ACCOUNT.HeaderText = "ID_ACCOUNT";
            this.ID_ACCOUNT.Name = "ID_ACCOUNT";
            this.ID_ACCOUNT.ReadOnly = true;
            this.ID_ACCOUNT.Visible = false;
            // 
            // btnChoose
            // 
            this.btnChoose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.ImageOptions.Image")));
            this.btnChoose.Location = new System.Drawing.Point(600, 427);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(89, 36);
            this.btnChoose.TabIndex = 10;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(719, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgv_DetailReceipt
            // 
            this.dgv_DetailReceipt.AllowUserToAddRows = false;
            this.dgv_DetailReceipt.AllowUserToDeleteRows = false;
            this.dgv_DetailReceipt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DetailReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetailReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ITEM,
            this.NAME,
            this.NAMEUNIT,
            this.NUMBER,
            this.PRICEOUT,
            this.SALE_OFF,
            this.TOTAL,
            this.ID_STAFF,
            this.NAME_STAFF});
            this.dgv_DetailReceipt.Location = new System.Drawing.Point(433, 52);
            this.dgv_DetailReceipt.Name = "dgv_DetailReceipt";
            this.dgv_DetailReceipt.ReadOnly = true;
            this.dgv_DetailReceipt.Size = new System.Drawing.Size(444, 368);
            this.dgv_DetailReceipt.TabIndex = 12;
            // 
            // ID_ITEM
            // 
            this.ID_ITEM.HeaderText = "ID_ITEM";
            this.ID_ITEM.Name = "ID_ITEM";
            this.ID_ITEM.ReadOnly = true;
            this.ID_ITEM.Visible = false;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "Mặt hàng";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 120;
            // 
            // NAMEUNIT
            // 
            this.NAMEUNIT.HeaderText = "ĐVT";
            this.NAMEUNIT.Name = "NAMEUNIT";
            this.NAMEUNIT.ReadOnly = true;
            this.NAMEUNIT.Width = 40;
            // 
            // NUMBER
            // 
            this.NUMBER.HeaderText = "SL";
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.ReadOnly = true;
            this.NUMBER.Width = 40;
            // 
            // PRICEOUT
            // 
            this.PRICEOUT.HeaderText = "Giá";
            this.PRICEOUT.Name = "PRICEOUT";
            this.PRICEOUT.ReadOnly = true;
            this.PRICEOUT.Width = 60;
            // 
            // SALE_OFF
            // 
            this.SALE_OFF.HeaderText = "CK";
            this.SALE_OFF.Name = "SALE_OFF";
            this.SALE_OFF.ReadOnly = true;
            this.SALE_OFF.Width = 40;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "Thành tiền";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // ID_STAFF
            // 
            this.ID_STAFF.HeaderText = "ID_STAFF";
            this.ID_STAFF.Name = "ID_STAFF";
            this.ID_STAFF.ReadOnly = true;
            this.ID_STAFF.Visible = false;
            // 
            // NAME_STAFF
            // 
            this.NAME_STAFF.HeaderText = "NV";
            this.NAME_STAFF.Name = "NAME_STAFF";
            this.NAME_STAFF.ReadOnly = true;
            // 
            // txtNameCus
            // 
            this.txtNameCus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCus.Location = new System.Drawing.Point(433, 12);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(209, 26);
            this.txtNameCus.TabIndex = 13;
            this.txtNameCus.TextChanged += new System.EventHandler(this.txtNameCus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm tên KH:";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCus);
            this.Controls.Add(this.dgv_DetailReceipt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dgv_Receipt);
            this.Controls.Add(this.dtP_End);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtP_Start);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỊCH HẸN";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtP_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtP_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Receipt;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.DataGridView dgv_DetailReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMEUNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICEOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALE_OFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_STAFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_STAFF;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CHAIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_CUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ACCOUNT;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label label3;
    }
}