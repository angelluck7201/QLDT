namespace QLDT.FormControls.DonHangForms
{
    partial class UcChiTietHangHoa
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcChiTietHangHoa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.gridControlChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridViewChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteRow = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.listHangHoa = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.btnSave);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtTenHang);
            this.splitContainerControl1.Panel1.Controls.Add(this.lblTenHang);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlChiTiet);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(699, 626);
            this.splitContainerControl1.SplitterPosition = 63;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.Location = new System.Drawing.Point(546, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 30);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.Location = new System.Drawing.Point(141, 24);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(339, 26);
            this.txtTenHang.TabIndex = 26;
            // 
            // lblTenHang
            // 
            this.lblTenHang.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(9, 29);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(92, 19);
            this.lblTenHang.TabIndex = 25;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // gridControlChiTiet
            // 
            this.gridControlChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChiTiet.Location = new System.Drawing.Point(0, 0);
            this.gridControlChiTiet.MainView = this.gridViewChiTiet;
            this.gridControlChiTiet.Name = "gridControlChiTiet";
            this.gridControlChiTiet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.listHangHoa,
            this.btnDeleteRow,
            this.repositoryItemTextEdit1});
            this.gridControlChiTiet.Size = new System.Drawing.Size(699, 557);
            this.gridControlChiTiet.TabIndex = 4;
            this.gridControlChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChiTiet});
            // 
            // gridViewChiTiet
            // 
            this.gridViewChiTiet.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridViewChiTiet.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewChiTiet.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridViewChiTiet.Appearance.Row.Options.UseFont = true;
            this.gridViewChiTiet.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridViewChiTiet.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewChiTiet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewChiTiet.ColumnPanelRowHeight = 30;
            this.gridViewChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn7,
            this.gridColumn5});
            this.gridViewChiTiet.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "AlertTon";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridViewChiTiet.FormatRules.Add(gridFormatRule1);
            this.gridViewChiTiet.GridControl = this.gridControlChiTiet;
            this.gridViewChiTiet.Name = "gridViewChiTiet";
            this.gridViewChiTiet.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewChiTiet.OptionsView.ShowFooter = true;
            this.gridViewChiTiet.OptionsView.ShowGroupPanel = false;
            this.gridViewChiTiet.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridViewChiTiet_ValidatingEditor);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.Caption = "IMEI";
            this.gridColumn2.FieldName = "IMEI";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IMEI", "SỐ LƯỢNG: {0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 396;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.btnDeleteRow;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 69;
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.Appearance.Image")));
            this.btnDeleteRow.Appearance.Options.UseImage = true;
            this.btnDeleteRow.AutoHeight = false;
            this.btnDeleteRow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnDeleteRow.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Nhấp đúp để xóa", null, null, true)});
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // listHangHoa
            // 
            this.listHangHoa.AutoHeight = false;
            this.listHangHoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listHangHoa.Name = "listHangHoa";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n0";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // UcChiTietHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UcChiTietHangHoa";
            this.Size = new System.Drawing.Size(699, 626);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label lblTenHang;
        private DevExpress.XtraGrid.GridControl gridControlChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteRow;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit listHangHoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}
