namespace SpaManagementSoftware
{
    partial class frmAddUserToGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUserToGroup));
            this.dS_GRAND = new SpaManagementSoftware.DS_GRAND();
            this.uSER_GROUP_USERDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_GROUP_USERDKTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.USER_GROUP_USERDKTableAdapter();
            this.tableAdapterManager = new SpaManagementSoftware.DS_GRANDTableAdapters.TableAdapterManager();
            this.aCCOUNTTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.ACCOUNTTableAdapter();
            this.gROUP_USERTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.GROUP_USERTableAdapter();
            this.uSER_GROUP_USERTableAdapter = new SpaManagementSoftware.DS_GRANDTableAdapters.USER_GROUP_USERTableAdapter();
            this.uSER_GROUP_USERDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gROUP_USERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP_USERComboBox = new System.Windows.Forms.ComboBox();
            this.btn_AddGrand = new DevExpress.XtraEditors.SimpleButton();
            this.uSER_GROUP_USERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DeleteGrand = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dS_GRAND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dS_GRAND
            // 
            this.dS_GRAND.DataSetName = "DS_GRAND";
            this.dS_GRAND.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSER_GROUP_USERDKBindingSource
            // 
            this.uSER_GROUP_USERDKBindingSource.DataMember = "USER_GROUP_USERDK";
            this.uSER_GROUP_USERDKBindingSource.DataSource = this.dS_GRAND;
            // 
            // uSER_GROUP_USERDKTableAdapter
            // 
            this.uSER_GROUP_USERDKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACCOUNTTableAdapter = this.aCCOUNTTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GRANT_RIGHTTableAdapter = null;
            this.tableAdapterManager.GROUP_USERTableAdapter = this.gROUP_USERTableAdapter;
            this.tableAdapterManager.SCREENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SpaManagementSoftware.DS_GRANDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_GROUP_USERDKTableAdapter = this.uSER_GROUP_USERDKTableAdapter;
            this.tableAdapterManager.USER_GROUP_USERTableAdapter = this.uSER_GROUP_USERTableAdapter;
            // 
            // aCCOUNTTableAdapter
            // 
            this.aCCOUNTTableAdapter.ClearBeforeFill = true;
            // 
            // gROUP_USERTableAdapter
            // 
            this.gROUP_USERTableAdapter.ClearBeforeFill = true;
            // 
            // uSER_GROUP_USERTableAdapter
            // 
            this.uSER_GROUP_USERTableAdapter.ClearBeforeFill = true;
            // 
            // uSER_GROUP_USERDKDataGridView
            // 
            this.uSER_GROUP_USERDKDataGridView.AllowUserToAddRows = false;
            this.uSER_GROUP_USERDKDataGridView.AllowUserToDeleteRows = false;
            this.uSER_GROUP_USERDKDataGridView.AutoGenerateColumns = false;
            this.uSER_GROUP_USERDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uSER_GROUP_USERDKDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.uSER_GROUP_USERDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uSER_GROUP_USERDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.uSER_GROUP_USERDKDataGridView.DataSource = this.uSER_GROUP_USERDKBindingSource;
            this.uSER_GROUP_USERDKDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uSER_GROUP_USERDKDataGridView.Location = new System.Drawing.Point(533, 88);
            this.uSER_GROUP_USERDKDataGridView.Name = "uSER_GROUP_USERDKDataGridView";
            this.uSER_GROUP_USERDKDataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.uSER_GROUP_USERDKDataGridView, 3);
            this.uSER_GROUP_USERDKDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uSER_GROUP_USERDKDataGridView.Size = new System.Drawing.Size(350, 336);
            this.uSER_GROUP_USERDKDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_GROUP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USER";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã TK";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // aCCOUNTBindingSource
            // 
            this.aCCOUNTBindingSource.DataMember = "ACCOUNT";
            this.aCCOUNTBindingSource.DataSource = this.dS_GRAND;
            // 
            // aCCOUNTDataGridView
            // 
            this.aCCOUNTDataGridView.AllowUserToAddRows = false;
            this.aCCOUNTDataGridView.AllowUserToDeleteRows = false;
            this.aCCOUNTDataGridView.AutoGenerateColumns = false;
            this.aCCOUNTDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aCCOUNTDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.aCCOUNTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aCCOUNTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tableLayoutPanel1.SetColumnSpan(this.aCCOUNTDataGridView, 2);
            this.aCCOUNTDataGridView.DataSource = this.aCCOUNTBindingSource;
            this.aCCOUNTDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aCCOUNTDataGridView.Location = new System.Drawing.Point(3, 88);
            this.aCCOUNTDataGridView.Name = "aCCOUNTDataGridView";
            this.aCCOUNTDataGridView.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.aCCOUNTDataGridView, 3);
            this.aCCOUNTDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aCCOUNTDataGridView.Size = new System.Drawing.Size(436, 336);
            this.aCCOUNTDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID_USER";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã TK";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "USERNAME";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên TK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PASSWORD";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mật Khẩu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "STATUS";
            this.dataGridViewTextBoxColumn7.HeaderText = "Trạng Thái";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // gROUP_USERBindingSource
            // 
            this.gROUP_USERBindingSource.DataMember = "GROUP_USER";
            this.gROUP_USERBindingSource.DataSource = this.dS_GRAND;
            // 
            // gROUP_USERComboBox
            // 
            this.gROUP_USERComboBox.DataSource = this.gROUP_USERBindingSource;
            this.gROUP_USERComboBox.DisplayMember = "NAME_GROUP";
            this.gROUP_USERComboBox.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gROUP_USERComboBox.FormattingEnabled = true;
            this.gROUP_USERComboBox.Location = new System.Drawing.Point(533, 57);
            this.gROUP_USERComboBox.Name = "gROUP_USERComboBox";
            this.gROUP_USERComboBox.Size = new System.Drawing.Size(168, 26);
            this.gROUP_USERComboBox.TabIndex = 4;
            this.gROUP_USERComboBox.ValueMember = "ID_GROUP";
            this.gROUP_USERComboBox.SelectedValueChanged += new System.EventHandler(this.gROUP_USERComboBox_SelectedValueChanged);
            // 
            // btn_AddGrand
            // 
            this.btn_AddGrand.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddGrand.Appearance.Options.UseFont = true;
            this.btn_AddGrand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddGrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddGrand.ImageOptions.Image")));
            this.btn_AddGrand.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_AddGrand.Location = new System.Drawing.Point(445, 196);
            this.btn_AddGrand.Name = "btn_AddGrand";
            this.btn_AddGrand.Size = new System.Drawing.Size(82, 35);
            this.btn_AddGrand.TabIndex = 5;
            this.btn_AddGrand.Click += new System.EventHandler(this.btn_Grand_Click);
            // 
            // uSER_GROUP_USERBindingSource
            // 
            this.uSER_GROUP_USERBindingSource.DataMember = "USER_GROUP_USER";
            this.uSER_GROUP_USERBindingSource.DataSource = this.dS_GRAND;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.aCCOUNTDataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.uSER_GROUP_USERDKDataGridView, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.gROUP_USERComboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddGrand, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_DeleteGrand, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.64637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.259953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 427);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân Nhóm Người Dùng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhóm người dùng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_DeleteGrand
            // 
            this.btn_DeleteGrand.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteGrand.Appearance.Options.UseFont = true;
            this.btn_DeleteGrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DeleteGrand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteGrand.ImageOptions.Image")));
            this.btn_DeleteGrand.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_DeleteGrand.Location = new System.Drawing.Point(445, 254);
            this.btn_DeleteGrand.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btn_DeleteGrand.Name = "btn_DeleteGrand";
            this.btn_DeleteGrand.Size = new System.Drawing.Size(82, 36);
            this.btn_DeleteGrand.TabIndex = 6;
            this.btn_DeleteGrand.Click += new System.EventHandler(this.btn_DeleteGrand_Click);
            // 
            // frmAddUserToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 427);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUserToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Người Dùng Vào Nhóm";
            this.Load += new System.EventHandler(this.frmAddUserToGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_GRAND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_USERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSER_GROUP_USERBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DS_GRAND dS_GRAND;
        private System.Windows.Forms.BindingSource uSER_GROUP_USERDKBindingSource;
        private DS_GRANDTableAdapters.USER_GROUP_USERDKTableAdapter uSER_GROUP_USERDKTableAdapter;
        private DS_GRANDTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_GRANDTableAdapters.ACCOUNTTableAdapter aCCOUNTTableAdapter;
        private System.Windows.Forms.DataGridView uSER_GROUP_USERDKDataGridView;
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private DS_GRANDTableAdapters.GROUP_USERTableAdapter gROUP_USERTableAdapter;
        private System.Windows.Forms.DataGridView aCCOUNTDataGridView;
        private System.Windows.Forms.BindingSource gROUP_USERBindingSource;
        private System.Windows.Forms.ComboBox gROUP_USERComboBox;
        private DevExpress.XtraEditors.SimpleButton btn_AddGrand;
        private DS_GRANDTableAdapters.USER_GROUP_USERTableAdapter uSER_GROUP_USERTableAdapter;
        private System.Windows.Forms.BindingSource uSER_GROUP_USERBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteGrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}