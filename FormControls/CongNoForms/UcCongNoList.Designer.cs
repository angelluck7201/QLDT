namespace QLDT.FormControls.CongNoForms
{
    partial class UcCongNoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCongNoList));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlCongNo = new DevExpress.XtraGrid.GridControl();
            this.gridViewCongNo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddCongNo = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chkNoOnly = new System.Windows.Forms.CheckBox();
            this.btnCongNoLoc = new DevExpress.XtraEditors.SimpleButton();
            this.CongNo_EndDate = new System.Windows.Forms.DateTimePicker();
            this.CongNo_StartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Trạng Thái";
            this.gridColumn24.FieldName = "TrangThai";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 5;
            this.gridColumn24.Width = 71;
            // 
            // gridControlCongNo
            // 
            this.gridControlCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCongNo.Location = new System.Drawing.Point(0, 0);
            this.gridControlCongNo.MainView = this.gridViewCongNo;
            this.gridControlCongNo.Name = "gridControlCongNo";
            this.gridControlCongNo.Size = new System.Drawing.Size(1792, 914);
            this.gridControlCongNo.TabIndex = 3;
            this.gridControlCongNo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCongNo,
            this.gridView3});
            // 
            // gridViewCongNo
            // 
            this.gridViewCongNo.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewCongNo.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewCongNo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewCongNo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewCongNo.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewCongNo.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewCongNo.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewCongNo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewCongNo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewCongNo.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCongNo.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewCongNo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCongNo.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewCongNo.Appearance.Row.Options.UseFont = true;
            this.gridViewCongNo.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewCongNo.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewCongNo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewCongNo.ColumnPanelRowHeight = 30;
            this.gridViewCongNo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21});
            this.gridViewCongNo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "AlertTon";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.LessOrEqual;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridViewCongNo.FormatRules.Add(gridFormatRule2);
            this.gridViewCongNo.GridControl = this.gridControlCongNo;
            this.gridViewCongNo.Name = "gridViewCongNo";
            this.gridViewCongNo.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewCongNo.OptionsBehavior.Editable = false;
            this.gridViewCongNo.OptionsCustomization.AllowGroup = false;
            this.gridViewCongNo.OptionsView.ShowAutoFilterRow = true;
            this.gridViewCongNo.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewCongNo.OptionsView.ShowFooter = true;
            this.gridViewCongNo.OptionsView.ShowGroupPanel = false;
            this.gridViewCongNo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn15, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewCongNo.DoubleClick += new System.EventHandler(this.gridViewCongNo_DoubleClick);
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn13.Caption = "Tên";
            this.gridColumn13.FieldName = "Ten";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 0;
            this.gridColumn13.Width = 331;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn14.Caption = "Điện Thoại";
            this.gridColumn14.FieldName = "Dienthoai";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 1;
            this.gridColumn14.Width = 180;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn15.Caption = "Ngày Chinh Sửa";
            this.gridColumn15.FieldName = "NgayChinhSua";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn15.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            this.gridColumn15.Width = 193;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn16.Caption = "Ghi Chú";
            this.gridColumn16.FieldName = "GhiChu";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 6;
            this.gridColumn16.Width = 205;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Id";
            this.gridColumn17.FieldName = "Id";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn19.Caption = "Nợ";
            this.gridColumn19.DisplayFormat.FormatString = "n0";
            this.gridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn19.FieldName = "No";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn19.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "No", "{0:n0}")});
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 3;
            this.gridColumn19.Width = 146;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn20.Caption = "Đã Thanh Toán";
            this.gridColumn20.DisplayFormat.FormatString = "n0";
            this.gridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn20.FieldName = "ThanhToan";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn20.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhToan", "{0:n0}")});
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 4;
            this.gridColumn20.Width = 171;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn21.Caption = "Còn Lại";
            this.gridColumn21.DisplayFormat.FormatString = "n0";
            this.gridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn21.FieldName = "ConLai";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.gridColumn21.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ConLai", "{0:n0}")});
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 5;
            this.gridColumn21.Width = 122;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControlCongNo;
            this.gridView3.Name = "gridView3";
            // 
            // btnAddCongNo
            // 
            this.btnAddCongNo.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddCongNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddCongNo.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCongNo.Appearance.Options.UseBackColor = true;
            this.btnAddCongNo.Appearance.Options.UseFont = true;
            this.btnAddCongNo.Appearance.Options.UseForeColor = true;
            this.btnAddCongNo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddCongNo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCongNo.Image")));
            this.btnAddCongNo.Location = new System.Drawing.Point(15, 18);
            this.btnAddCongNo.Name = "btnAddCongNo";
            this.btnAddCongNo.Size = new System.Drawing.Size(281, 44);
            this.btnAddCongNo.TabIndex = 46;
            this.btnAddCongNo.Text = "Nhập Công Nợ Cũ";
            this.btnAddCongNo.Click += new System.EventHandler(this.btnAddCongNo_Click);
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerControl3.Appearance.Options.UseBackColor = true;
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Horizontal = false;
            this.splitContainerControl3.IsSplitterFixed = true;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.chkNoOnly);
            this.splitContainerControl3.Panel1.Controls.Add(this.btnCongNoLoc);
            this.splitContainerControl3.Panel1.Controls.Add(this.CongNo_EndDate);
            this.splitContainerControl3.Panel1.Controls.Add(this.CongNo_StartDate);
            this.splitContainerControl3.Panel1.Controls.Add(this.btnAddCongNo);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.gridControlCongNo);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1792, 994);
            this.splitContainerControl3.SplitterPosition = 70;
            this.splitContainerControl3.TabIndex = 4;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // chkNoOnly
            // 
            this.chkNoOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoOnly.AutoSize = true;
            this.chkNoOnly.Checked = true;
            this.chkNoOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoOnly.Font = new System.Drawing.Font("Tahoma", 9F);
            this.chkNoOnly.Location = new System.Drawing.Point(433, 27);
            this.chkNoOnly.Name = "chkNoOnly";
            this.chkNoOnly.Size = new System.Drawing.Size(330, 33);
            this.chkNoOnly.TabIndex = 52;
            this.chkNoOnly.Text = "Chỉ Hiển Thị Khách Còn Nợ";
            this.chkNoOnly.UseVisualStyleBackColor = true;
            this.chkNoOnly.CheckStateChanged += new System.EventHandler(this.chkNoOnly_CheckStateChanged);
            // 
            // btnCongNoLoc
            // 
            this.btnCongNoLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCongNoLoc.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCongNoLoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnCongNoLoc.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCongNoLoc.Appearance.Options.UseBackColor = true;
            this.btnCongNoLoc.Appearance.Options.UseFont = true;
            this.btnCongNoLoc.Appearance.Options.UseForeColor = true;
            this.btnCongNoLoc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCongNoLoc.Location = new System.Drawing.Point(1648, 26);
            this.btnCongNoLoc.Name = "btnCongNoLoc";
            this.btnCongNoLoc.Size = new System.Drawing.Size(124, 36);
            this.btnCongNoLoc.TabIndex = 50;
            this.btnCongNoLoc.Text = "Lọc";
            this.btnCongNoLoc.Click += new System.EventHandler(this.btnCongNoLoc_Click);
            // 
            // CongNo_EndDate
            // 
            this.CongNo_EndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CongNo_EndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.CongNo_EndDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CongNo_EndDate.Location = new System.Drawing.Point(1201, 25);
            this.CongNo_EndDate.Name = "CongNo_EndDate";
            this.CongNo_EndDate.Size = new System.Drawing.Size(408, 36);
            this.CongNo_EndDate.TabIndex = 49;
            // 
            // CongNo_StartDate
            // 
            this.CongNo_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CongNo_StartDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.CongNo_StartDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CongNo_StartDate.Location = new System.Drawing.Point(785, 27);
            this.CongNo_StartDate.Name = "CongNo_StartDate";
            this.CongNo_StartDate.Size = new System.Drawing.Size(400, 36);
            this.CongNo_StartDate.TabIndex = 48;
            // 
            // UcCongNoList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerControl3);
            this.Name = "UcCongNoList";
            this.Size = new System.Drawing.Size(1792, 994);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.GridControl gridControlCongNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCongNo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btnAddCongNo;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.SimpleButton btnCongNoLoc;
        private System.Windows.Forms.DateTimePicker CongNo_EndDate;
        private System.Windows.Forms.DateTimePicker CongNo_StartDate;
        private System.Windows.Forms.CheckBox chkNoOnly;
    }
}
