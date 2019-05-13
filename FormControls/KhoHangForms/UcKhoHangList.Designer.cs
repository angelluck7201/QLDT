namespace QLDT.FormControls.KhoHangForms
{
    partial class UcKhoHangList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcKhoHangList));
            this.IsAlertTon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonLyTuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlLoaiHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewLoaiHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddHangHoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddNhomHang = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsAlertTon
            // 
            this.IsAlertTon.Caption = "IsAlertTon";
            this.IsAlertTon.FieldName = "IsAlertTon";
            this.IsAlertTon.Name = "IsAlertTon";
            this.IsAlertTon.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // colSoLuong
            // 
            this.colSoLuong.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.colSoLuong.Caption = "Tồn Kho";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoLuong", "{0:n0}")});
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 119;
            // 
            // colTonLyTuong
            // 
            this.colTonLyTuong.Caption = "TonLyTuong";
            this.colTonLyTuong.FieldName = "TonLytuong";
            this.colTonLyTuong.Name = "colTonLyTuong";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlLoaiHang);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlHangHoa);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1192, 596);
            this.splitContainerControl1.SplitterPosition = 278;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControlLoaiHang
            // 
            this.gridControlLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlLoaiHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlLoaiHang.Location = new System.Drawing.Point(0, 0);
            this.gridControlLoaiHang.MainView = this.gridViewLoaiHang;
            this.gridControlLoaiHang.Name = "gridControlLoaiHang";
            this.gridControlLoaiHang.Size = new System.Drawing.Size(278, 596);
            this.gridControlLoaiHang.TabIndex = 0;
            this.gridControlLoaiHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoaiHang});
            // 
            // gridViewLoaiHang
            // 
            this.gridViewLoaiHang.Appearance.FocusedCell.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewLoaiHang.Appearance.FocusedCell.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewLoaiHang.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridViewLoaiHang.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridViewLoaiHang.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewLoaiHang.Appearance.FocusedRow.BackColor2 = System.Drawing.SystemColors.Highlight;
            this.gridViewLoaiHang.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewLoaiHang.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewLoaiHang.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewLoaiHang.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewLoaiHang.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewLoaiHang.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewLoaiHang.Appearance.Row.Options.UseFont = true;
            this.gridViewLoaiHang.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridViewLoaiHang.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewLoaiHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewLoaiHang.ColumnPanelRowHeight = 30;
            this.gridViewLoaiHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8});
            this.gridViewLoaiHang.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewLoaiHang.GridControl = this.gridControlLoaiHang;
            this.gridViewLoaiHang.Name = "gridViewLoaiHang";
            this.gridViewLoaiHang.OptionsBehavior.Editable = false;
            this.gridViewLoaiHang.OptionsView.ShowAutoFilterRow = true;
            this.gridViewLoaiHang.OptionsView.ShowGroupPanel = false;
            this.gridViewLoaiHang.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn8, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewLoaiHang.Click += new System.EventHandler(this.gridViewLoaiHang_Click);
            this.gridViewLoaiHang.DoubleClick += new System.EventHandler(this.gridViewLoaiHang_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.Caption = "Hãng Sản Xuất";
            this.gridColumn1.FieldName = "Ten";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Id";
            this.gridColumn8.FieldName = "Id";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridControlHangHoa
            // 
            this.gridControlHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHangHoa.Location = new System.Drawing.Point(0, 0);
            this.gridControlHangHoa.MainView = this.gridViewHangHoa;
            this.gridControlHangHoa.Name = "gridControlHangHoa";
            this.gridControlHangHoa.Size = new System.Drawing.Size(904, 596);
            this.gridControlHangHoa.TabIndex = 1;
            this.gridControlHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewHangHoa.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewHangHoa.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewHangHoa.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewHangHoa.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewHangHoa.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewHangHoa.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewHangHoa.Appearance.Row.Options.UseFont = true;
            this.gridViewHangHoa.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.gridViewHangHoa.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewHangHoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewHangHoa.ColumnPanelRowHeight = 30;
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.colSoLuong,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn9,
            this.colTonLyTuong,
            this.IsAlertTon,
            this.gridColumn4});
            this.gridViewHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.IsAlertTon;
            gridFormatRule1.ColumnApplyTo = this.colSoLuong;
            gridFormatRule1.Name = "AlertTon";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseFont = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "1";
            formatConditionRuleValue1.Value1 = true;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.gridViewHangHoa.FormatRules.Add(gridFormatRule1);
            this.gridViewHangHoa.GridControl = this.gridControlHangHoa;
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsBehavior.Editable = false;
            this.gridViewHangHoa.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHangHoa.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewHangHoa.OptionsView.ShowFooter = true;
            this.gridViewHangHoa.OptionsView.ShowGroupPanel = false;
            this.gridViewHangHoa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.IsAlertTon, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewHangHoa.DoubleClick += new System.EventHandler(this.gridViewHangHoa_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.Caption = "Tên Hàng";
            this.gridColumn2.FieldName = "TenHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 240;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn3.Caption = "ĐVT";
            this.gridColumn3.FieldName = "DVT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 59;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.Caption = "Giá Bán";
            this.gridColumn5.DisplayFormat.FormatString = "n0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "GiaBan";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 134;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.gridColumn6.Caption = "Ghi Chú";
            this.gridColumn6.FieldName = "GhiChu";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 228;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "LoaiHangId";
            this.gridColumn9.FieldName = "LoaiHangId";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tổng Giá Trị";
            this.gridColumn4.DisplayFormat.FormatString = "n0";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "GiaTri";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GiaTri", "{0:n0}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 149;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerControl2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.IsSplitterFixed = true;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnAddHangHoa);
            this.splitContainerControl2.Panel1.Controls.Add(this.btnAddNhomHang);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1192, 666);
            this.splitContainerControl2.SplitterPosition = 60;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(924, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(253, 44);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Cập Nhật Số Lượng";
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddHangHoa
            // 
            this.btnAddHangHoa.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddHangHoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnAddHangHoa.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddHangHoa.Appearance.Options.UseBackColor = true;
            this.btnAddHangHoa.Appearance.Options.UseFont = true;
            this.btnAddHangHoa.Appearance.Options.UseForeColor = true;
            this.btnAddHangHoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddHangHoa.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHangHoa.Image")));
            this.btnAddHangHoa.Location = new System.Drawing.Point(288, 12);
            this.btnAddHangHoa.Name = "btnAddHangHoa";
            this.btnAddHangHoa.Size = new System.Drawing.Size(243, 44);
            this.btnAddHangHoa.TabIndex = 4;
            this.btnAddHangHoa.Text = "Thêm Hàng Hóa";
            this.btnAddHangHoa.Click += new System.EventHandler(this.btnAddHangHoa_Click);
            // 
            // btnAddNhomHang
            // 
            this.btnAddNhomHang.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddNhomHang.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnAddNhomHang.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNhomHang.Appearance.Options.UseBackColor = true;
            this.btnAddNhomHang.Appearance.Options.UseFont = true;
            this.btnAddNhomHang.Appearance.Options.UseForeColor = true;
            this.btnAddNhomHang.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAddNhomHang.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNhomHang.Image")));
            this.btnAddNhomHang.Location = new System.Drawing.Point(13, 12);
            this.btnAddNhomHang.Name = "btnAddNhomHang";
            this.btnAddNhomHang.Size = new System.Drawing.Size(265, 44);
            this.btnAddNhomHang.TabIndex = 3;
            this.btnAddNhomHang.Text = "Thêm Hãng Sản Xuất";
            this.btnAddNhomHang.Click += new System.EventHandler(this.btnAddNhomHang_Click);
            // 
            // UcKhoHangList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.splitContainerControl2);
            this.Name = "UcKhoHangList";
            this.Size = new System.Drawing.Size(1192, 666);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlLoaiHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gridControlHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddHangHoa;
        private DevExpress.XtraEditors.SimpleButton btnAddNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colTonLyTuong;
        private DevExpress.XtraGrid.Columns.GridColumn IsAlertTon;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}
