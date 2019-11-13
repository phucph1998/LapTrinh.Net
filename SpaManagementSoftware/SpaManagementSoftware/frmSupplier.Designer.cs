namespace SpaManagementSoftware
{
    partial class frmSupplier
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
            this.tLP_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.tCtr_Member = new System.Windows.Forms.TabControl();
            this.tP_Member = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tV_GroupSup = new System.Windows.Forms.TreeView();
            this.tS_TypeSupplier = new System.Windows.Forms.ToolStrip();
            this.tSP_AddGroup = new System.Windows.Forms.ToolStripButton();
            this.tSP_EditGroup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSP_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tCtr_Customer = new System.Windows.Forms.TabControl();
            this.tP_Customer = new System.Windows.Forms.TabPage();
            this.tLP_DetailCus = new System.Windows.Forms.TableLayoutPanel();
            this.tS_Supplier = new System.Windows.Forms.ToolStrip();
            this.tSB_Add = new System.Windows.Forms.ToolStripButton();
            this.tSP_Edit = new System.Windows.Forms.ToolStripButton();
            this.tSB_Delete = new System.Windows.Forms.ToolStripButton();
            this.dGV_Supplier = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMS_GroupSup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tLP_Customer.SuspendLayout();
            this.tCtr_Member.SuspendLayout();
            this.tP_Member.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tS_TypeSupplier.SuspendLayout();
            this.tCtr_Customer.SuspendLayout();
            this.tP_Customer.SuspendLayout();
            this.tLP_DetailCus.SuspendLayout();
            this.tS_Supplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tLP_Customer
            // 
            this.tLP_Customer.ColumnCount = 2;
            this.tLP_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tLP_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tLP_Customer.Controls.Add(this.tCtr_Member, 0, 0);
            this.tLP_Customer.Controls.Add(this.tCtr_Customer, 1, 0);
            this.tLP_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Customer.Location = new System.Drawing.Point(0, 0);
            this.tLP_Customer.Name = "tLP_Customer";
            this.tLP_Customer.RowCount = 1;
            this.tLP_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Customer.Size = new System.Drawing.Size(975, 465);
            this.tLP_Customer.TabIndex = 1;
            // 
            // tCtr_Member
            // 
            this.tCtr_Member.Controls.Add(this.tP_Member);
            this.tCtr_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Member.Location = new System.Drawing.Point(3, 3);
            this.tCtr_Member.Name = "tCtr_Member";
            this.tCtr_Member.SelectedIndex = 0;
            this.tCtr_Member.Size = new System.Drawing.Size(247, 459);
            this.tCtr_Member.TabIndex = 0;
            // 
            // tP_Member
            // 
            this.tP_Member.Controls.Add(this.tableLayoutPanel1);
            this.tP_Member.Location = new System.Drawing.Point(4, 22);
            this.tP_Member.Name = "tP_Member";
            this.tP_Member.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Member.Size = new System.Drawing.Size(239, 433);
            this.tP_Member.TabIndex = 0;
            this.tP_Member.Text = "Nhóm Nhà Cung Cấp";
            this.tP_Member.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tV_GroupSup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tS_TypeSupplier, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.125678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.87432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 427);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tV_GroupSup
            // 
            this.tV_GroupSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_GroupSup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tV_GroupSup.Location = new System.Drawing.Point(3, 24);
            this.tV_GroupSup.Name = "tV_GroupSup";
            this.tV_GroupSup.Size = new System.Drawing.Size(227, 400);
            this.tV_GroupSup.TabIndex = 0;
            this.tV_GroupSup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_GroupSup_AfterSelect);
            // 
            // tS_TypeSupplier
            // 
            this.tS_TypeSupplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSP_AddGroup,
            this.tSP_EditGroup,
            this.toolStripSeparator1,
            this.tSP_Refresh});
            this.tS_TypeSupplier.Location = new System.Drawing.Point(0, 0);
            this.tS_TypeSupplier.Name = "tS_TypeSupplier";
            this.tS_TypeSupplier.Size = new System.Drawing.Size(233, 21);
            this.tS_TypeSupplier.TabIndex = 1;
            this.tS_TypeSupplier.Text = "toolStrip1";
            // 
            // tSP_AddGroup
            // 
            this.tSP_AddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_AddGroup.Image = global::SpaManagementSoftware.Properties.Resources.add;
            this.tSP_AddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_AddGroup.Name = "tSP_AddGroup";
            this.tSP_AddGroup.Size = new System.Drawing.Size(23, 18);
            this.tSP_AddGroup.Text = "toolStripButton2";
            this.tSP_AddGroup.Click += new System.EventHandler(this.tSP_AddGroup_Click);
            // 
            // tSP_EditGroup
            // 
            this.tSP_EditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_EditGroup.Image = global::SpaManagementSoftware.Properties.Resources.Edit_16x16;
            this.tSP_EditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_EditGroup.Name = "tSP_EditGroup";
            this.tSP_EditGroup.Size = new System.Drawing.Size(23, 18);
            this.tSP_EditGroup.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 21);
            // 
            // tSP_Refresh
            // 
            this.tSP_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_Refresh.Image = global::SpaManagementSoftware.Properties.Resources.Refresh_16x16;
            this.tSP_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Refresh.Name = "tSP_Refresh";
            this.tSP_Refresh.Size = new System.Drawing.Size(23, 18);
            this.tSP_Refresh.Text = "toolStripButton4";
            // 
            // tCtr_Customer
            // 
            this.tCtr_Customer.Controls.Add(this.tP_Customer);
            this.tCtr_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Customer.Location = new System.Drawing.Point(256, 3);
            this.tCtr_Customer.Name = "tCtr_Customer";
            this.tCtr_Customer.SelectedIndex = 0;
            this.tCtr_Customer.Size = new System.Drawing.Size(716, 459);
            this.tCtr_Customer.TabIndex = 1;
            // 
            // tP_Customer
            // 
            this.tP_Customer.Controls.Add(this.tLP_DetailCus);
            this.tP_Customer.Location = new System.Drawing.Point(4, 22);
            this.tP_Customer.Name = "tP_Customer";
            this.tP_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Customer.Size = new System.Drawing.Size(708, 433);
            this.tP_Customer.TabIndex = 0;
            this.tP_Customer.Text = "Nhà Cung Cấp";
            this.tP_Customer.UseVisualStyleBackColor = true;
            // 
            // tLP_DetailCus
            // 
            this.tLP_DetailCus.ColumnCount = 1;
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_DetailCus.Controls.Add(this.tS_Supplier, 0, 0);
            this.tLP_DetailCus.Controls.Add(this.dGV_Supplier, 0, 1);
            this.tLP_DetailCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_DetailCus.Location = new System.Drawing.Point(3, 3);
            this.tLP_DetailCus.Name = "tLP_DetailCus";
            this.tLP_DetailCus.RowCount = 2;
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tLP_DetailCus.Size = new System.Drawing.Size(702, 427);
            this.tLP_DetailCus.TabIndex = 0;
            // 
            // tS_Supplier
            // 
            this.tS_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tS_Supplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Add,
            this.tSP_Edit,
            this.tSB_Delete});
            this.tS_Supplier.Location = new System.Drawing.Point(0, 0);
            this.tS_Supplier.Name = "tS_Supplier";
            this.tS_Supplier.Size = new System.Drawing.Size(702, 21);
            this.tS_Supplier.TabIndex = 0;
            this.tS_Supplier.Text = "toolStrip1";
            // 
            // tSB_Add
            // 
            this.tSB_Add.Image = global::SpaManagementSoftware.Properties.Resources.Add_16x16;
            this.tSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Add.Name = "tSB_Add";
            this.tSB_Add.Size = new System.Drawing.Size(81, 18);
            this.tSB_Add.Text = "Thêm Mới";
            this.tSB_Add.Click += new System.EventHandler(this.tSB_Add_Click);
            // 
            // tSP_Edit
            // 
            this.tSP_Edit.Image = global::SpaManagementSoftware.Properties.Resources.Edit_16x16;
            this.tSP_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Edit.Name = "tSP_Edit";
            this.tSP_Edit.Size = new System.Drawing.Size(81, 18);
            this.tSP_Edit.Text = "Chỉnh Sửa";
            this.tSP_Edit.Click += new System.EventHandler(this.tSP_Edit_Click);
            // 
            // tSB_Delete
            // 
            this.tSB_Delete.Image = global::SpaManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Delete.Name = "tSB_Delete";
            this.tSB_Delete.Size = new System.Drawing.Size(47, 18);
            this.tSB_Delete.Text = "Xóa";
            this.tSB_Delete.Click += new System.EventHandler(this.tSB_Delete_Click);
            // 
            // dGV_Supplier
            // 
            this.dGV_Supplier.AllowUserToAddRows = false;
            this.dGV_Supplier.AllowUserToDeleteRows = false;
            this.dGV_Supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Supplier.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Supplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.PHONE,
            this.EMAIL,
            this.ADDRESS,
            this.TAX_CODE,
            this.ID_GROUP});
            this.dGV_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Supplier.Location = new System.Drawing.Point(3, 24);
            this.dGV_Supplier.MultiSelect = false;
            this.dGV_Supplier.Name = "dGV_Supplier";
            this.dGV_Supplier.ReadOnly = true;
            this.dGV_Supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Supplier.Size = new System.Drawing.Size(696, 400);
            this.dGV_Supplier.TabIndex = 1;
            this.dGV_Supplier.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Supplier_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã NCC";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Tên NCC";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Số ĐT";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa chỉ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // TAX_CODE
            // 
            this.TAX_CODE.DataPropertyName = "TAX_CODE";
            this.TAX_CODE.HeaderText = "Mã Số Kinh Doanh";
            this.TAX_CODE.Name = "TAX_CODE";
            this.TAX_CODE.ReadOnly = true;
            // 
            // ID_GROUP
            // 
            this.ID_GROUP.DataPropertyName = "ID_GROUP";
            this.ID_GROUP.HeaderText = "Mã nhóm";
            this.ID_GROUP.Name = "ID_GROUP";
            this.ID_GROUP.ReadOnly = true;
            this.ID_GROUP.Visible = false;
            // 
            // cMS_GroupSup
            // 
            this.cMS_GroupSup.Name = "cMS_GroupSup";
            this.cMS_GroupSup.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 465);
            this.Controls.Add(this.tLP_Customer);
            this.Name = "frmSupplier";
            this.Text = "Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.tLP_Customer.ResumeLayout(false);
            this.tCtr_Member.ResumeLayout(false);
            this.tP_Member.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tS_TypeSupplier.ResumeLayout(false);
            this.tS_TypeSupplier.PerformLayout();
            this.tCtr_Customer.ResumeLayout(false);
            this.tP_Customer.ResumeLayout(false);
            this.tLP_DetailCus.ResumeLayout(false);
            this.tLP_DetailCus.PerformLayout();
            this.tS_Supplier.ResumeLayout(false);
            this.tS_Supplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Supplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Customer;
        private System.Windows.Forms.TabControl tCtr_Member;
        private System.Windows.Forms.TabPage tP_Member;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView tV_GroupSup;
        private System.Windows.Forms.ToolStrip tS_TypeSupplier;
        private System.Windows.Forms.ToolStripButton tSP_AddGroup;
        private System.Windows.Forms.ToolStripButton tSP_EditGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSP_Refresh;
        private System.Windows.Forms.TabControl tCtr_Customer;
        private System.Windows.Forms.TabPage tP_Customer;
        private System.Windows.Forms.TableLayoutPanel tLP_DetailCus;
        private System.Windows.Forms.ToolStrip tS_Supplier;
        private System.Windows.Forms.ToolStripButton tSB_Add;
        private System.Windows.Forms.ToolStripButton tSP_Edit;
        private System.Windows.Forms.ToolStripButton tSB_Delete;
        private System.Windows.Forms.DataGridView dGV_Supplier;
        private System.Windows.Forms.ContextMenuStrip cMS_GroupSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GROUP;
    }
}