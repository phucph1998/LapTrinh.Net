namespace SpaManagementSoftware
{
    partial class frmSearchItems
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
            this.tV_GroupItem = new System.Windows.Forms.TreeView();
            this.dgV_Items = new System.Windows.Forms.DataGridView();
            this.NAME_ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // tV_GroupItem
            // 
            this.tV_GroupItem.Location = new System.Drawing.Point(8, 43);
            this.tV_GroupItem.Name = "tV_GroupItem";
            this.tV_GroupItem.Size = new System.Drawing.Size(216, 417);
            this.tV_GroupItem.TabIndex = 2;
            this.tV_GroupItem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_GroupItem_AfterSelect);
            // 
            // dgV_Items
            // 
            this.dgV_Items.AllowUserToAddRows = false;
            this.dgV_Items.AllowUserToDeleteRows = false;
            this.dgV_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgV_Items.BackgroundColor = System.Drawing.Color.White;
            this.dgV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgV_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME_ITEM,
            this.NAME_UNIT,
            this.PRICE_IN,
            this.ID});
            this.dgV_Items.Location = new System.Drawing.Point(230, 43);
            this.dgV_Items.Name = "dgV_Items";
            this.dgV_Items.ReadOnly = true;
            this.dgV_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgV_Items.Size = new System.Drawing.Size(426, 417);
            this.dgV_Items.TabIndex = 3;
            this.dgV_Items.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgV_Items_CellDoubleClick);
            // 
            // NAME_ITEM
            // 
            this.NAME_ITEM.DataPropertyName = "NAME_ITEM";
            this.NAME_ITEM.HeaderText = "Vật tư";
            this.NAME_ITEM.Name = "NAME_ITEM";
            this.NAME_ITEM.ReadOnly = true;
            // 
            // NAME_UNIT
            // 
            this.NAME_UNIT.DataPropertyName = "NAME_UNIT";
            this.NAME_UNIT.HeaderText = "Đơn vị tính";
            this.NAME_UNIT.Name = "NAME_UNIT";
            this.NAME_UNIT.ReadOnly = true;
            // 
            // PRICE_IN
            // 
            this.PRICE_IN.DataPropertyName = "PRICE_IN";
            this.PRICE_IN.HeaderText = "Đơn giá";
            this.PRICE_IN.Name = "PRICE_IN";
            this.PRICE_IN.ReadOnly = true;
            this.PRICE_IN.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(473, 466);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(82, 38);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtNameItem
            // 
            this.txtNameItem.Location = new System.Drawing.Point(95, 13);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(242, 21);
            this.txtNameItem.TabIndex = 5;
            this.txtNameItem.TextChanged += new System.EventHandler(this.txtNameItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(574, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSearchItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 509);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.dgV_Items);
            this.Controls.Add(this.tV_GroupItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.frmSearchItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgV_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tV_GroupItem;
        private System.Windows.Forms.DataGridView dgV_Items;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_UNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}