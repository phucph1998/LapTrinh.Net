namespace SpaManagementSoftware
{
    partial class frmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUP_USERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gRANT_RIGHTDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gROUP_USERDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUP_USERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dS_GRAND = new SpaManagementSoftware.DS_GRAND();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gRANT_RIGHTDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gRANT_RIGHTDKBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gRANT_RIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP_USERTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.GROUP_USERTableAdapter();
            this.tableAdapterManager = new SpaManagementSoftware.DS_GRANDTableAdapters.TableAdapterManager();
            this.gRANT_RIGHTTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.GRANT_RIGHTTableAdapter();
            this.gRANT_RIGHTDKTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.GRANT_RIGHTDKTableAdapter();
            this.gRANT_RIGHTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GRAND)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_GROUP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NAME_GROUP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_SCREEN";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NAME_SCREEN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ROLE";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Có Quyền";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gROUP_USERDataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm người dùng";
            // 
            // gROUP_USERDataGridView
            // 
            this.gROUP_USERDataGridView.AllowUserToAddRows = false;
            this.gROUP_USERDataGridView.AllowUserToDeleteRows = false;
            this.gROUP_USERDataGridView.AutoGenerateColumns = false;
            this.gROUP_USERDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gROUP_USERDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.gROUP_USERDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gROUP_USERDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.gROUP_USERDataGridView.DataSource = this.gROUP_USERBindingSource1;
            this.gROUP_USERDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gROUP_USERDataGridView.Location = new System.Drawing.Point(3, 17);
            this.gROUP_USERDataGridView.MultiSelect = false;
            this.gROUP_USERDataGridView.Name = "gROUP_USERDataGridView";
            this.gROUP_USERDataGridView.ReadOnly = true;
            this.gROUP_USERDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gROUP_USERDataGridView.Size = new System.Drawing.Size(449, 287);
            this.gROUP_USERDataGridView.TabIndex = 0;
            this.gROUP_USERDataGridView.SelectionChanged += new System.EventHandler(this.gROUP_USERDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_GROUP";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NAME_GROUP";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên Nhóm";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn8.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // gROUP_USERBindingSource1
            // 
            this.gROUP_USERBindingSource1.DataMember = "GROUP_USER";
            this.gROUP_USERBindingSource1.DataSource = this.dS_GRAND;
            // 
            // dS_GRAND
            // 
            this.dS_GRAND.DataSetName = "DS_GRAND";
            this.dS_GRAND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.gRANT_RIGHTDKDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(464, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 307);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách quyền chức năng";
            // 
            // gRANT_RIGHTDKDataGridView
            // 
            this.gRANT_RIGHTDKDataGridView.AllowUserToAddRows = false;
            this.gRANT_RIGHTDKDataGridView.AllowUserToDeleteRows = false;
            this.gRANT_RIGHTDKDataGridView.AutoGenerateColumns = false;
            this.gRANT_RIGHTDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gRANT_RIGHTDKDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.gRANT_RIGHTDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRANT_RIGHTDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewCheckBoxColumn2});
            this.gRANT_RIGHTDKDataGridView.DataSource = this.gRANT_RIGHTDKBindingSource1;
            this.gRANT_RIGHTDKDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRANT_RIGHTDKDataGridView.Location = new System.Drawing.Point(3, 17);
            this.gRANT_RIGHTDKDataGridView.MultiSelect = false;
            this.gRANT_RIGHTDKDataGridView.Name = "gRANT_RIGHTDKDataGridView";
            this.gRANT_RIGHTDKDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gRANT_RIGHTDKDataGridView.Size = new System.Drawing.Size(502, 287);
            this.gRANT_RIGHTDKDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID_SCREEN";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã Màn Hình";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NAME_SCREEN";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tên Màn Hình";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ROLE";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Có Quyền";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // gRANT_RIGHTDKBindingSource1
            // 
            this.gRANT_RIGHTDKBindingSource1.DataMember = "GRANT_RIGHTDK";
            this.gRANT_RIGHTDKBindingSource1.DataSource = this.dS_GRAND;
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(710, 3);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 28);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(837, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 28);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Hủy bỏ";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "PHÂN QUYỀN NHÓM NGƯỜI DÙNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gROUP_USERTableAdapter
            // 
            this.gROUP_USERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GRANT_RIGHTTableAdapter = this.gRANT_RIGHTTableAdapter;
            this.tableAdapterManager.GROUP_USERTableAdapter = this.gROUP_USERTableAdapter;
            this.tableAdapterManager.SCREENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaManagementSoftware.DS_GRANDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_GROUP_USERDKTableAdapter = null;
            this.tableAdapterManager.USER_GROUP_USERTableAdapter = null;
            // 
            // gRANT_RIGHTTableAdapter
            // 
            this.gRANT_RIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // gRANT_RIGHTDKTableAdapter
            // 
            this.gRANT_RIGHTDKTableAdapter.ClearBeforeFill = true;
            // 
            // gRANT_RIGHTBindingSource1
            // 
            this.gRANT_RIGHTBindingSource1.DataMember = "GRANT_RIGHT";
            this.gRANT_RIGHTBindingSource1.DataSource = this.dS_GRAND;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.29775F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.34755F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3547F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Save, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(975, 347);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // frmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 347);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Quyền Chức Năng";
            this.Load += new System.EventHandler(this.frmRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GRAND)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTDKBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRANT_RIGHTBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_GRAND dS_GRAND;
        private System.Windows.Forms.BindingSource gROUP_USERBindingSource;
        private DS_GRANDTableAdapters.GROUP_USERTableAdapter gROUP_USERTableAdapter;
        private DS_GRANDTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_GRANDTableAdapters.GRANT_RIGHTTableAdapter gRANT_RIGHTTableAdapter;
        private System.Windows.Forms.BindingSource gRANT_RIGHTBindingSource;
        private System.Windows.Forms.BindingSource gRANT_RIGHTDKBindingSource;
        private DS_GRANDTableAdapters.GRANT_RIGHTDKTableAdapter gRANT_RIGHTDKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gROUP_USERDataGridView;
        private System.Windows.Forms.BindingSource gROUP_USERBindingSource1;
        private System.Windows.Forms.BindingSource gRANT_RIGHTBindingSource1;
        private System.Windows.Forms.BindingSource gRANT_RIGHTDKBindingSource1;
        private System.Windows.Forms.DataGridView gRANT_RIGHTDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}