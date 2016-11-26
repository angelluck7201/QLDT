namespace QLDT.FormControls.UserAccountForms
{
    partial class UcUserAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcUserAccount));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.UserAccount_TenNguoiDung = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.UserAccount_DiaChi = new System.Windows.Forms.RichTextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.UserAccount_CMND = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.UserAccount_Dienthoai = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.UserAccount_TenNhanVien = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.UserAccount_GhiChu = new System.Windows.Forms.RichTextBox();
            this.gridControlPermission = new DevExpress.XtraGrid.GridControl();
            this.gridViewPermission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listPermission = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnLock = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCancel.Location = new System.Drawing.Point(10, 24);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Hủy";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Location = new System.Drawing.Point(973, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.btnLock);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnCancel);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnReset);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1089, 684);
            this.splitContainerControl1.SplitterPosition = 609;
            this.splitContainerControl1.TabIndex = 78;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.lblTenNguoiDung);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_TenNguoiDung);
            this.splitContainerControl2.Panel1.Controls.Add(this.lblDiaChi);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_DiaChi);
            this.splitContainerControl2.Panel1.Controls.Add(this.lblCMND);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_CMND);
            this.splitContainerControl2.Panel1.Controls.Add(this.lblDienthoai);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_Dienthoai);
            this.splitContainerControl2.Panel1.Controls.Add(this.lblTenNhanVien);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_TenNhanVien);
            this.splitContainerControl2.Panel1.Controls.Add(this.lblGhiChu);
            this.splitContainerControl2.Panel1.Controls.Add(this.UserAccount_GhiChu);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlPermission);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1089, 609);
            this.splitContainerControl2.SplitterPosition = 561;
            this.splitContainerControl2.TabIndex = 88;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.Location = new System.Drawing.Point(27, 73);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(122, 19);
            this.lblTenNguoiDung.TabIndex = 99;
            this.lblTenNguoiDung.Text = "Tên Tài Khoản";
            // 
            // UserAccount_TenNguoiDung
            // 
            this.UserAccount_TenNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_TenNguoiDung.Location = new System.Drawing.Point(174, 66);
            this.UserAccount_TenNguoiDung.Name = "UserAccount_TenNguoiDung";
            this.UserAccount_TenNguoiDung.Size = new System.Drawing.Size(352, 26);
            this.UserAccount_TenNguoiDung.TabIndex = 1;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(27, 151);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 19);
            this.lblDiaChi.TabIndex = 97;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // UserAccount_DiaChi
            // 
            this.UserAccount_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_DiaChi.Location = new System.Drawing.Point(174, 157);
            this.UserAccount_DiaChi.Name = "UserAccount_DiaChi";
            this.UserAccount_DiaChi.Size = new System.Drawing.Size(352, 96);
            this.UserAccount_DiaChi.TabIndex = 3;
            this.UserAccount_DiaChi.Text = "";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(27, 270);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(58, 19);
            this.lblCMND.TabIndex = 96;
            this.lblCMND.Text = "CMND";
            // 
            // UserAccount_CMND
            // 
            this.UserAccount_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_CMND.Location = new System.Drawing.Point(174, 270);
            this.UserAccount_CMND.Name = "UserAccount_CMND";
            this.UserAccount_CMND.Size = new System.Drawing.Size(352, 26);
            this.UserAccount_CMND.TabIndex = 4;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienthoai.Location = new System.Drawing.Point(27, 112);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(92, 19);
            this.lblDienthoai.TabIndex = 95;
            this.lblDienthoai.Text = "Điện Thoại";
            // 
            // UserAccount_Dienthoai
            // 
            this.UserAccount_Dienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_Dienthoai.Location = new System.Drawing.Point(174, 107);
            this.UserAccount_Dienthoai.Name = "UserAccount_Dienthoai";
            this.UserAccount_Dienthoai.Size = new System.Drawing.Size(352, 26);
            this.UserAccount_Dienthoai.TabIndex = 2;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(27, 33);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(123, 19);
            this.lblTenNhanVien.TabIndex = 94;
            this.lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // UserAccount_TenNhanVien
            // 
            this.UserAccount_TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_TenNhanVien.Location = new System.Drawing.Point(174, 26);
            this.UserAccount_TenNhanVien.Name = "UserAccount_TenNhanVien";
            this.UserAccount_TenNhanVien.Size = new System.Drawing.Size(352, 26);
            this.UserAccount_TenNhanVien.TabIndex = 0;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(27, 317);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 19);
            this.lblGhiChu.TabIndex = 93;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // UserAccount_GhiChu
            // 
            this.UserAccount_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserAccount_GhiChu.Location = new System.Drawing.Point(174, 317);
            this.UserAccount_GhiChu.Name = "UserAccount_GhiChu";
            this.UserAccount_GhiChu.Size = new System.Drawing.Size(352, 96);
            this.UserAccount_GhiChu.TabIndex = 5;
            this.UserAccount_GhiChu.Text = "";
            // 
            // gridControlPermission
            // 
            this.gridControlPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPermission.Location = new System.Drawing.Point(0, 0);
            this.gridControlPermission.MainView = this.gridViewPermission;
            this.gridControlPermission.Name = "gridControlPermission";
            this.gridControlPermission.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.listPermission,
            this.btnDeleteRow,
            this.repositoryItemTextEdit1});
            this.gridControlPermission.Size = new System.Drawing.Size(522, 609);
            this.gridControlPermission.TabIndex = 0;
            this.gridControlPermission.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPermission});
            // 
            // gridViewPermission
            // 
            this.gridViewPermission.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridViewPermission.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewPermission.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewPermission.Appearance.Row.Options.UseFont = true;
            this.gridViewPermission.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridViewPermission.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewPermission.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewPermission.ColumnPanelRowHeight = 30;
            this.gridViewPermission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn7});
            this.gridViewPermission.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "AlertTon";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridViewPermission.FormatRules.Add(gridFormatRule2);
            this.gridViewPermission.GridControl = this.gridControlPermission;
            this.gridViewPermission.Name = "gridViewPermission";
            this.gridViewPermission.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewPermission.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewPermission.OptionsView.ShowFooter = true;
            this.gridViewPermission.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "Quyền";
            this.gridColumn2.ColumnEdit = this.listPermission;
            this.gridColumn2.FieldName = "Permission";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 296;
            // 
            // listPermission
            // 
            this.listPermission.AutoHeight = false;
            this.listPermission.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listPermission.Name = "listPermission";
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10F);
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Tính Năng";
            this.gridColumn4.FieldName = "Feature";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 206;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.Appearance.Image")));
            this.btnDeleteRow.Appearance.Options.UseImage = true;
            this.btnDeleteRow.AutoHeight = false;
            this.btnDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Nhấp đúp để xóa", null, null, true)});
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnLock
            // 
            this.btnLock.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLock.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnLock.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLock.Appearance.Options.UseBackColor = true;
            this.btnLock.Appearance.Options.UseFont = true;
            this.btnLock.Appearance.Options.UseForeColor = true;
            this.btnLock.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnLock.Location = new System.Drawing.Point(647, 24);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(156, 30);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Khóa Tài Khoản";
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnReset.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Appearance.Options.UseBackColor = true;
            this.btnReset.Appearance.Options.UseFont = true;
            this.btnReset.Appearance.Options.UseForeColor = true;
            this.btnReset.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnReset.Location = new System.Drawing.Point(809, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(158, 30);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset Mật Khẩu";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // UcUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UcUserAccount";
            this.Size = new System.Drawing.Size(1089, 684);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.RichTextBox UserAccount_DiaChi;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox UserAccount_CMND;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.TextBox UserAccount_Dienthoai;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.TextBox UserAccount_TenNhanVien;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.RichTextBox UserAccount_GhiChu;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.TextBox UserAccount_TenNguoiDung;
        private DevExpress.XtraGrid.GridControl gridControlPermission;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit listPermission;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLock;
        private DevExpress.XtraEditors.SimpleButton btnReset;
    }
}
