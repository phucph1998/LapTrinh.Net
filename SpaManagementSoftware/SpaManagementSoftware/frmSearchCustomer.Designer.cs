namespace SpaManagementSoftware
{
    partial class frmSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchCustomer));
            this.dGV_Customer = new System.Windows.Forms.DataGridView();
            this.ID_PROFILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Customer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Customer
            // 
            this.dGV_Customer.AllowUserToAddRows = false;
            this.dGV_Customer.AllowUserToDeleteRows = false;
            this.dGV_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Customer.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROFILE,
            this.NAME,
            this.SEX,
            this.ADDRESS,
            this.PHONE,
            this.BIRTHDAY,
            this.NAME_TYPE,
            this.SCORE,
            this.STATUS,
            this.IMAGE});
            this.dGV_Customer.Location = new System.Drawing.Point(12, 101);
            this.dGV_Customer.MultiSelect = false;
            this.dGV_Customer.Name = "dGV_Customer";
            this.dGV_Customer.ReadOnly = true;
            this.dGV_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Customer.Size = new System.Drawing.Size(658, 271);
            this.dGV_Customer.TabIndex = 2;
            // 
            // ID_PROFILE
            // 
            this.ID_PROFILE.DataPropertyName = "ID_PROFILE";
            this.ID_PROFILE.HeaderText = "Mã KH";
            this.ID_PROFILE.Name = "ID_PROFILE";
            this.ID_PROFILE.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Tên KH";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // SEX
            // 
            this.SEX.DataPropertyName = "SEX";
            this.SEX.HeaderText = "Giới Tính";
            this.SEX.Name = "SEX";
            this.SEX.ReadOnly = true;
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
            this.PHONE.HeaderText = "Điện Thoại";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.DataPropertyName = "BIRTHDAY";
            this.BIRTHDAY.HeaderText = "Ngày Sinh";
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.ReadOnly = true;
            this.BIRTHDAY.Visible = false;
            // 
            // NAME_TYPE
            // 
            this.NAME_TYPE.DataPropertyName = "NAME1";
            this.NAME_TYPE.HeaderText = "Loại KH";
            this.NAME_TYPE.Name = "NAME_TYPE";
            this.NAME_TYPE.ReadOnly = true;
            // 
            // SCORE
            // 
            this.SCORE.DataPropertyName = "SCORE";
            this.SCORE.HeaderText = "Điểm TL";
            this.SCORE.Name = "SCORE";
            this.SCORE.ReadOnly = true;
            this.SCORE.Visible = false;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng Thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Visible = false;
            // 
            // IMAGE
            // 
            this.IMAGE.DataPropertyName = "IMAGE";
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.ReadOnly = true;
            this.IMAGE.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 51);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SpaManagementSoftware.Properties.Resources.search_cus1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Thông Tin Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá trị tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 72);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(247, 21);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.add;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btnAdd.Location = new System.Drawing.Point(15, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm KH";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(490, 379);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(77, 31);
            this.btnChoose.TabIndex = 7;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(593, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.btnEdit.Location = new System.Drawing.Point(108, 378);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 32);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 415);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGV_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÌM KIẾM KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROFILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
    }
}