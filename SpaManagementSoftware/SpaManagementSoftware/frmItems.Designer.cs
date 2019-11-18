namespace SpaManagementSoftware
{
    partial class frmItems
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
            this.tLP_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.tCtr_Member = new System.Windows.Forms.TabControl();
            this.tP_GroupItem = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tV_GroupItem = new System.Windows.Forms.TreeView();
            this.tS_TypeCus = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tCtr_Customer = new System.Windows.Forms.TabControl();
            this.tP_Items = new System.Windows.Forms.TabPage();
            this.tLP_DetailCus = new System.Windows.Forms.TableLayoutPanel();
            this.tS_Customer = new System.Windows.Forms.ToolStrip();
            this.dGV_Items = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_OUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROSE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROSE_RATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tSP_AddGroup = new System.Windows.Forms.ToolStripButton();
            this.tSP_EditGroup = new System.Windows.Forms.ToolStripButton();
            this.tSP_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tSB_Add = new System.Windows.Forms.ToolStripButton();
            this.tSP_Edit = new System.Windows.Forms.ToolStripButton();
            this.tSB_Delete = new System.Windows.Forms.ToolStripButton();
            this.tLP_Customer.SuspendLayout();
            this.tCtr_Member.SuspendLayout();
            this.tP_GroupItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tS_TypeCus.SuspendLayout();
            this.tCtr_Customer.SuspendLayout();
            this.tP_Items.SuspendLayout();
            this.tLP_DetailCus.SuspendLayout();
            this.tS_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Items)).BeginInit();
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
            this.tLP_Customer.Size = new System.Drawing.Size(916, 480);
            this.tLP_Customer.TabIndex = 1;
            // 
            // tCtr_Member
            // 
            this.tCtr_Member.Controls.Add(this.tP_GroupItem);
            this.tCtr_Member.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Member.Location = new System.Drawing.Point(3, 3);
            this.tCtr_Member.Name = "tCtr_Member";
            this.tCtr_Member.SelectedIndex = 0;
            this.tCtr_Member.Size = new System.Drawing.Size(232, 474);
            this.tCtr_Member.TabIndex = 0;
            // 
            // tP_GroupItem
            // 
            this.tP_GroupItem.Controls.Add(this.tableLayoutPanel1);
            this.tP_GroupItem.Location = new System.Drawing.Point(4, 22);
            this.tP_GroupItem.Name = "tP_GroupItem";
            this.tP_GroupItem.Padding = new System.Windows.Forms.Padding(3);
            this.tP_GroupItem.Size = new System.Drawing.Size(224, 448);
            this.tP_GroupItem.TabIndex = 0;
            this.tP_GroupItem.Text = "Loại Hàng";
            this.tP_GroupItem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tV_GroupItem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tS_TypeCus, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.125678F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.87432F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 442);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tV_GroupItem
            // 
            this.tV_GroupItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tV_GroupItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tV_GroupItem.Location = new System.Drawing.Point(3, 25);
            this.tV_GroupItem.Name = "tV_GroupItem";
            this.tV_GroupItem.Size = new System.Drawing.Size(212, 414);
            this.tV_GroupItem.TabIndex = 0;
            this.tV_GroupItem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_GroupItem_AfterSelect);
            // 
            // tS_TypeCus
            // 
            this.tS_TypeCus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSP_AddGroup,
            this.tSP_EditGroup,
            this.toolStripSeparator1,
            this.tSP_Refresh});
            this.tS_TypeCus.Location = new System.Drawing.Point(0, 0);
            this.tS_TypeCus.Name = "tS_TypeCus";
            this.tS_TypeCus.Size = new System.Drawing.Size(218, 22);
            this.tS_TypeCus.TabIndex = 1;
            this.tS_TypeCus.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 22);
            // 
            // tCtr_Customer
            // 
            this.tCtr_Customer.Controls.Add(this.tP_Items);
            this.tCtr_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tCtr_Customer.Location = new System.Drawing.Point(241, 3);
            this.tCtr_Customer.Name = "tCtr_Customer";
            this.tCtr_Customer.SelectedIndex = 0;
            this.tCtr_Customer.Size = new System.Drawing.Size(672, 474);
            this.tCtr_Customer.TabIndex = 1;
            // 
            // tP_Items
            // 
            this.tP_Items.Controls.Add(this.tLP_DetailCus);
            this.tP_Items.Location = new System.Drawing.Point(4, 22);
            this.tP_Items.Name = "tP_Items";
            this.tP_Items.Padding = new System.Windows.Forms.Padding(3);
            this.tP_Items.Size = new System.Drawing.Size(664, 448);
            this.tP_Items.TabIndex = 0;
            this.tP_Items.Text = "Mặt Hàng";
            this.tP_Items.UseVisualStyleBackColor = true;
            // 
            // tLP_DetailCus
            // 
            this.tLP_DetailCus.ColumnCount = 1;
            this.tLP_DetailCus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_DetailCus.Controls.Add(this.tS_Customer, 0, 0);
            this.tLP_DetailCus.Controls.Add(this.dGV_Items, 0, 1);
            this.tLP_DetailCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_DetailCus.Location = new System.Drawing.Point(3, 3);
            this.tLP_DetailCus.Name = "tLP_DetailCus";
            this.tLP_DetailCus.RowCount = 2;
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_DetailCus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tLP_DetailCus.Size = new System.Drawing.Size(658, 442);
            this.tLP_DetailCus.TabIndex = 0;
            // 
            // tS_Customer
            // 
            this.tS_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tS_Customer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSB_Add,
            this.tSP_Edit,
            this.tSB_Delete});
            this.tS_Customer.Location = new System.Drawing.Point(0, 0);
            this.tS_Customer.Name = "tS_Customer";
            this.tS_Customer.Size = new System.Drawing.Size(658, 22);
            this.tS_Customer.TabIndex = 0;
            this.tS_Customer.Text = "toolStrip1";
            // 
            // dGV_Items
            // 
            this.dGV_Items.AllowUserToAddRows = false;
            this.dGV_Items.AllowUserToDeleteRows = false;
            this.dGV_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Items.BackgroundColor = System.Drawing.Color.White;
            this.dGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ID_GROUP,
            this.ID_UNIT,
            this.NAME,
            this.NAME_UNIT,
            this.PRICE_OUT,
            this.PRICE_IN,
            this.ROSE,
            this.ROSE_RATE});
            this.dGV_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Items.Location = new System.Drawing.Point(3, 25);
            this.dGV_Items.MultiSelect = false;
            this.dGV_Items.Name = "dGV_Items";
            this.dGV_Items.ReadOnly = true;
            this.dGV_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Items.Size = new System.Drawing.Size(652, 414);
            this.dGV_Items.TabIndex = 1;
            this.dGV_Items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Items_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ID_GROUP
            // 
            this.ID_GROUP.DataPropertyName = "ID_GROUP";
            this.ID_GROUP.HeaderText = "ID_GROUP";
            this.ID_GROUP.Name = "ID_GROUP";
            this.ID_GROUP.ReadOnly = true;
            this.ID_GROUP.Visible = false;
            // 
            // ID_UNIT
            // 
            this.ID_UNIT.DataPropertyName = "ID_UNIT";
            this.ID_UNIT.HeaderText = "ID_UNIT";
            this.ID_UNIT.Name = "ID_UNIT";
            this.ID_UNIT.ReadOnly = true;
            this.ID_UNIT.Visible = false;
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Mặt hàng";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // NAME_UNIT
            // 
            this.NAME_UNIT.DataPropertyName = "NAME_UNIT";
            this.NAME_UNIT.HeaderText = "Đơn VT";
            this.NAME_UNIT.Name = "NAME_UNIT";
            this.NAME_UNIT.ReadOnly = true;
            // 
            // PRICE_OUT
            // 
            this.PRICE_OUT.DataPropertyName = "PRICE_OUT";
            this.PRICE_OUT.HeaderText = "Giá Bán";
            this.PRICE_OUT.Name = "PRICE_OUT";
            this.PRICE_OUT.ReadOnly = true;
            // 
            // PRICE_IN
            // 
            this.PRICE_IN.DataPropertyName = "PRICE_IN";
            this.PRICE_IN.HeaderText = "Giá Nhập";
            this.PRICE_IN.Name = "PRICE_IN";
            this.PRICE_IN.ReadOnly = true;
            // 
            // ROSE
            // 
            this.ROSE.DataPropertyName = "ROSE";
            this.ROSE.HeaderText = "Hoa Hồng";
            this.ROSE.Name = "ROSE";
            this.ROSE.ReadOnly = true;
            // 
            // ROSE_RATE
            // 
            this.ROSE_RATE.DataPropertyName = "ROSE_RATE";
            this.ROSE_RATE.HeaderText = "Tỉ lệ hoa hồng";
            this.ROSE_RATE.Name = "ROSE_RATE";
            this.ROSE_RATE.ReadOnly = true;
            // 
            // tSP_AddGroup
            // 
            this.tSP_AddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_AddGroup.Image = global::SpaManagementSoftware.Properties.Resources.add;
            this.tSP_AddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_AddGroup.Name = "tSP_AddGroup";
            this.tSP_AddGroup.Size = new System.Drawing.Size(23, 19);
            this.tSP_AddGroup.Text = "toolStripButton2";
            this.tSP_AddGroup.Click += new System.EventHandler(this.tSP_AddGroup_Click);
            // 
            // tSP_EditGroup
            // 
            this.tSP_EditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_EditGroup.Image = global::SpaManagementSoftware.Properties.Resources.Edit_16x16;
            this.tSP_EditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_EditGroup.Name = "tSP_EditGroup";
            this.tSP_EditGroup.Size = new System.Drawing.Size(23, 19);
            this.tSP_EditGroup.Text = "toolStripButton3";
            this.tSP_EditGroup.Click += new System.EventHandler(this.tSP_EditGroup_Click);
            // 
            // tSP_Refresh
            // 
            this.tSP_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSP_Refresh.Image = global::SpaManagementSoftware.Properties.Resources.Refresh_16x16;
            this.tSP_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Refresh.Name = "tSP_Refresh";
            this.tSP_Refresh.Size = new System.Drawing.Size(23, 19);
            this.tSP_Refresh.Text = "toolStripButton4";
            this.tSP_Refresh.Click += new System.EventHandler(this.tSP_Refresh_Click);
            // 
            // tSB_Add
            // 
            this.tSB_Add.Image = global::SpaManagementSoftware.Properties.Resources.add;
            this.tSB_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Add.Name = "tSB_Add";
            this.tSB_Add.Size = new System.Drawing.Size(81, 19);
            this.tSB_Add.Text = "Thêm Mới";
            this.tSB_Add.Click += new System.EventHandler(this.tSB_Add_Click);
            // 
            // tSP_Edit
            // 
            this.tSP_Edit.Image = global::SpaManagementSoftware.Properties.Resources.Edit_16x16;
            this.tSP_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSP_Edit.Name = "tSP_Edit";
            this.tSP_Edit.Size = new System.Drawing.Size(81, 19);
            this.tSP_Edit.Text = "Chỉnh Sửa";
            this.tSP_Edit.Click += new System.EventHandler(this.tSP_Edit_Click);
            // 
            // tSB_Delete
            // 
            this.tSB_Delete.Image = global::SpaManagementSoftware.Properties.Resources.Delete_16x16;
            this.tSB_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_Delete.Name = "tSB_Delete";
            this.tSB_Delete.Size = new System.Drawing.Size(47, 19);
            this.tSB_Delete.Text = "Xóa";
            this.tSB_Delete.Click += new System.EventHandler(this.tSB_Delete_Click);
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 480);
            this.Controls.Add(this.tLP_Customer);
            this.Name = "frmItems";
            this.Text = "Danh Mục Mặt Hàng";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.tLP_Customer.ResumeLayout(false);
            this.tCtr_Member.ResumeLayout(false);
            this.tP_GroupItem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tS_TypeCus.ResumeLayout(false);
            this.tS_TypeCus.PerformLayout();
            this.tCtr_Customer.ResumeLayout(false);
            this.tP_Items.ResumeLayout(false);
            this.tLP_DetailCus.ResumeLayout(false);
            this.tLP_DetailCus.PerformLayout();
            this.tS_Customer.ResumeLayout(false);
            this.tS_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Customer;
        private System.Windows.Forms.TabControl tCtr_Member;
        private System.Windows.Forms.TabPage tP_GroupItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView tV_GroupItem;
        private System.Windows.Forms.ToolStrip tS_TypeCus;
        private System.Windows.Forms.ToolStripButton tSP_AddGroup;
        private System.Windows.Forms.ToolStripButton tSP_EditGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSP_Refresh;
        private System.Windows.Forms.TabControl tCtr_Customer;
        private System.Windows.Forms.TabPage tP_Items;
        private System.Windows.Forms.TableLayoutPanel tLP_DetailCus;
        private System.Windows.Forms.ToolStrip tS_Customer;
        private System.Windows.Forms.ToolStripButton tSB_Add;
        private System.Windows.Forms.ToolStripButton tSP_Edit;
        private System.Windows.Forms.ToolStripButton tSB_Delete;
        private System.Windows.Forms.DataGridView dGV_Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GROUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_OUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROSE_RATE;
    }
}