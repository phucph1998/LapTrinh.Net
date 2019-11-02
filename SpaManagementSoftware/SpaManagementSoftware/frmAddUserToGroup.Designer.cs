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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUserToGroup));
            this.btn_AddGrand = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DeleteGrand = new DevExpress.XtraEditors.SimpleButton();
            this.dGV_User = new System.Windows.Forms.DataGridView();
            this.USER_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGV_UsGroupUs = new System.Windows.Forms.DataGridView();
            this.cbb_NameGroup = new System.Windows.Forms.ComboBox();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_GROUP_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_UsGroupUs)).BeginInit();
            this.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_AddGrand, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_DeleteGrand, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dGV_User, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dGV_UsGroupUs, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbb_NameGroup, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.64637F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.259953F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // dGV_User
            // 
            this.dGV_User.AllowUserToAddRows = false;
            this.dGV_User.AllowUserToDeleteRows = false;
            this.dGV_User.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_User.BackgroundColor = System.Drawing.Color.White;
            this.dGV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_User.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_NAME,
            this.PASSWORD,
            this.STATUS});
            this.tableLayoutPanel1.SetColumnSpan(this.dGV_User, 2);
            this.dGV_User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_User.GridColor = System.Drawing.Color.Gray;
            this.dGV_User.Location = new System.Drawing.Point(3, 88);
            this.dGV_User.Name = "dGV_User";
            this.dGV_User.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dGV_User, 3);
            this.dGV_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_User.Size = new System.Drawing.Size(436, 336);
            this.dGV_User.TabIndex = 7;
            // 
            // USER_NAME
            // 
            this.USER_NAME.DataPropertyName = "USER_NAME";
            this.USER_NAME.HeaderText = "Tên Tài Khoản";
            this.USER_NAME.Name = "USER_NAME";
            this.USER_NAME.ReadOnly = true;
            // 
            // PASSWORD
            // 
            this.PASSWORD.DataPropertyName = "PASSWORD";
            this.PASSWORD.HeaderText = "Mật khẩu";
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng thái";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // dGV_UsGroupUs
            // 
            this.dGV_UsGroupUs.AllowUserToAddRows = false;
            this.dGV_UsGroupUs.AllowUserToDeleteRows = false;
            this.dGV_UsGroupUs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_UsGroupUs.BackgroundColor = System.Drawing.Color.White;
            this.dGV_UsGroupUs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_UsGroupUs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.ID_GROUP_USER,
            this.STATUS1});
            this.dGV_UsGroupUs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_UsGroupUs.Location = new System.Drawing.Point(533, 88);
            this.dGV_UsGroupUs.Name = "dGV_UsGroupUs";
            this.dGV_UsGroupUs.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dGV_UsGroupUs, 3);
            this.dGV_UsGroupUs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_UsGroupUs.Size = new System.Drawing.Size(350, 336);
            this.dGV_UsGroupUs.TabIndex = 8;
            // 
            // cbb_NameGroup
            // 
            this.cbb_NameGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_NameGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_NameGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbb_NameGroup.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NameGroup.FormattingEnabled = true;
            this.cbb_NameGroup.Location = new System.Drawing.Point(533, 57);
            this.cbb_NameGroup.Name = "cbb_NameGroup";
            this.cbb_NameGroup.Size = new System.Drawing.Size(148, 22);
            this.cbb_NameGroup.TabIndex = 9;
            this.cbb_NameGroup.SelectedValueChanged += new System.EventHandler(this.cbb_NameGroup_SelectedValueChanged);
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USER_NAME";
            this.USERNAME.HeaderText = "Tên Tài Khoản";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // ID_GROUP_USER
            // 
            this.ID_GROUP_USER.DataPropertyName = "ID_GROUP_USER";
            this.ID_GROUP_USER.HeaderText = "Mã Nhóm Người Dùng";
            this.ID_GROUP_USER.Name = "ID_GROUP_USER";
            this.ID_GROUP_USER.ReadOnly = true;
            // 
            // STATUS1
            // 
            this.STATUS1.DataPropertyName = "STATUS";
            this.STATUS1.HeaderText = "Trạng Thái";
            this.STATUS1.Name = "STATUS1";
            this.STATUS1.ReadOnly = true;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_UsGroupUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_AddGrand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_DeleteGrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGV_User;
        private System.Windows.Forms.DataGridView dGV_UsGroupUs;
        private System.Windows.Forms.ComboBox cbb_NameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GROUP_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS1;
    }
}