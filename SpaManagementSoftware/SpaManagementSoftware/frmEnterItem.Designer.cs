namespace SpaManagementSoftware
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
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtP_End = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtP_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgV_EnterCoupon = new System.Windows.Forms.DataGridView();
            this.CREATE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESON_ENTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgV_DetailCoupon = new System.Windows.Forms.DataGridView();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTO_MONEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ENTER_COUPON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSumMoney = new System.Windows.Forms.Label();
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
            this.btn_EditCoupon.Click += new System.EventHandler(this.btn_EditCoupon_Click);
            // 
            // btn_DeleteCoupon
            // 
            this.btn_DeleteCoupon.Image = global::SpaManagementSoftware.Properties.Resources.remove;
            this.btn_DeleteCoupon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteCoupon.Name = "btn_DeleteCoupon";
            this.btn_DeleteCoupon.Size = new System.Drawing.Size(80, 22);
            this.btn_DeleteCoupon.Text = "Xóa phiếu";
            this.btn_DeleteCoupon.Click += new System.EventHandler(this.btn_DeleteCoupon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
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
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.Refresh2_16x16;
            this.btnRefresh.Location = new System.Drawing.Point(356, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.ImageOptions.Image = global::SpaManagementSoftware.Properties.Resources.Lookup_Reference_16x16;
            this.btn_Search.Location = new System.Drawing.Point(323, 43);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(27, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.dtP_End.CustomFormat = "dd/MM/yyyy";
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
            this.dtP_Start.CustomFormat = "dd/MM/yyyy";
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
            this.dgV_EnterCoupon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgV_EnterCoupon.BackgroundColor = System.Drawing.Color.White;
            this.dgV_EnterCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_EnterCoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CREATE_DATE,
            this.ID,
            this.NAME,
            this.RESON_ENTER});
            this.dgV_EnterCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_EnterCoupon.Location = new System.Drawing.Point(3, 110);
            this.dgV_EnterCoupon.Name = "dgV_EnterCoupon";
            this.dgV_EnterCoupon.ReadOnly = true;
            this.dgV_EnterCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgV_EnterCoupon.Size = new System.Drawing.Size(438, 376);
            this.dgV_EnterCoupon.TabIndex = 2;
            this.dgV_EnterCoupon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgV_EnterCoupon_CellClick);
            this.dgV_EnterCoupon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgV_EnterCoupon_CellDoubleClick);
            // 
            // CREATE_DATE
            // 
            this.CREATE_DATE.DataPropertyName = "CREATE_DATE";
            this.CREATE_DATE.HeaderText = "Ngày tạo";
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
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Nhân Viên";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // RESON_ENTER
            // 
            this.RESON_ENTER.DataPropertyName = "RESON_ENTER";
            this.RESON_ENTER.HeaderText = "Lý do nhập";
            this.RESON_ENTER.Name = "RESON_ENTER";
            this.RESON_ENTER.ReadOnly = true;
            // 
            // dgV_DetailCoupon
            // 
            this.dgV_DetailCoupon.AllowUserToAddRows = false;
            this.dgV_DetailCoupon.AllowUserToDeleteRows = false;
            this.dgV_DetailCoupon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgV_DetailCoupon.BackgroundColor = System.Drawing.Color.White;
            this.dgV_DetailCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_DetailCoupon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME_ITEM,
            this.NUMBER,
            this.PRICE_IN,
            this.INTO_MONEY,
            this.ID_ENTER_COUPON,
            this.ID_ITEM});
            this.dgV_DetailCoupon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgV_DetailCoupon.Location = new System.Drawing.Point(447, 29);
            this.dgV_DetailCoupon.Name = "dgV_DetailCoupon";
            this.dgV_DetailCoupon.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgV_DetailCoupon, 2);
            this.dgV_DetailCoupon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgV_DetailCoupon.Size = new System.Drawing.Size(439, 457);
            this.dgV_DetailCoupon.TabIndex = 3;
            // 
            // NAME_ITEM
            // 
            this.NAME_ITEM.DataPropertyName = "NAME_ITEM";
            this.NAME_ITEM.HeaderText = "Mặt hàng";
            this.NAME_ITEM.Name = "NAME_ITEM";
            this.NAME_ITEM.ReadOnly = true;
            // 
            // NUMBER
            // 
            this.NUMBER.DataPropertyName = "NUMBER";
            this.NUMBER.HeaderText = "Số lượng";
            this.NUMBER.Name = "NUMBER";
            this.NUMBER.ReadOnly = true;
            // 
            // PRICE_IN
            // 
            this.PRICE_IN.DataPropertyName = "PRICE_IN";
            this.PRICE_IN.HeaderText = "Đơn giá";
            this.PRICE_IN.Name = "PRICE_IN";
            this.PRICE_IN.ReadOnly = true;
            // 
            // INTO_MONEY
            // 
            this.INTO_MONEY.DataPropertyName = "INTO_MONEY";
            this.INTO_MONEY.HeaderText = "Thành tiền";
            this.INTO_MONEY.Name = "INTO_MONEY";
            this.INTO_MONEY.ReadOnly = true;
            // 
            // ID_ENTER_COUPON
            // 
            this.ID_ENTER_COUPON.DataPropertyName = "ID_ENTER_COUPON";
            this.ID_ENTER_COUPON.HeaderText = "ID_ENTER_COUPON";
            this.ID_ENTER_COUPON.Name = "ID_ENTER_COUPON";
            this.ID_ENTER_COUPON.ReadOnly = true;
            this.ID_ENTER_COUPON.Visible = false;
            // 
            // ID_ITEM
            // 
            this.ID_ITEM.DataPropertyName = "ID_ITEM";
            this.ID_ITEM.HeaderText = "ID_ITEM";
            this.ID_ITEM.Name = "ID_ITEM";
            this.ID_ITEM.ReadOnly = true;
            this.ID_ITEM.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSumMoney);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(447, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 20);
            this.panel2.TabIndex = 4;
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumMoney.ForeColor = System.Drawing.Color.Red;
            this.lblSumMoney.Location = new System.Drawing.Point(299, 1);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.Size = new System.Drawing.Size(135, 18);
            this.lblSumMoney.TabIndex = 1;
            this.lblSumMoney.Text = "Số tiền của phiếu";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 4);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblSumMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESON_ENTER;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTO_MONEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ENTER_COUPON;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_ITEM;
    }
}