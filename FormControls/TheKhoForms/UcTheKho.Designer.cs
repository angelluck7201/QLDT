namespace QLDT.FormControls.TheKhoForms
{
    partial class UcTheKho
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhapKhoLoc = new DevExpress.XtraEditors.SimpleButton();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.gridControlHangHoa = new DevExpress.XtraGrid.GridControl();
            this.gridViewHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlHangHoa);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1854, 1211);
            this.splitContainerControl1.SplitterPosition = 79;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNhapKhoLoc);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(332, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1522, 79);
            this.panel1.TabIndex = 6;
            // 
            // btnNhapKhoLoc
            // 
            this.btnNhapKhoLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNhapKhoLoc.Appearance.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNhapKhoLoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnNhapKhoLoc.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNhapKhoLoc.Appearance.Options.UseBackColor = true;
            this.btnNhapKhoLoc.Appearance.Options.UseFont = true;
            this.btnNhapKhoLoc.Appearance.Options.UseForeColor = true;
            this.btnNhapKhoLoc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNhapKhoLoc.Location = new System.Drawing.Point(1308, 19);
            this.btnNhapKhoLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhapKhoLoc.Name = "btnNhapKhoLoc";
            this.btnNhapKhoLoc.Size = new System.Drawing.Size(160, 36);
            this.btnNhapKhoLoc.TabIndex = 50;
            this.btnNhapKhoLoc.Text = "Lọc";
            this.btnNhapKhoLoc.Click += new System.EventHandler(this.btnNhapKhoLoc_Click);
            // 
            // EndDate
            // 
            this.EndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.EndDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.EndDate.Location = new System.Drawing.Point(793, 19);
            this.EndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(464, 36);
            this.EndDate.TabIndex = 49;
            // 
            // StartDate
            // 
            this.StartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F);
            this.StartDate.Font = new System.Drawing.Font("Tahoma", 9F);
            this.StartDate.Location = new System.Drawing.Point(308, 19);
            this.StartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(464, 36);
            this.StartDate.TabIndex = 48;
            // 
            // gridControlHangHoa
            // 
            this.gridControlHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHangHoa.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlHangHoa.Location = new System.Drawing.Point(0, 0);
            this.gridControlHangHoa.MainView = this.gridViewHangHoa;
            this.gridControlHangHoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControlHangHoa.Name = "gridControlHangHoa";
            this.gridControlHangHoa.Size = new System.Drawing.Size(1854, 1122);
            this.gridControlHangHoa.TabIndex = 3;
            this.gridControlHangHoa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHangHoa});
            // 
            // gridViewHangHoa
            // 
            this.gridViewHangHoa.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridViewHangHoa.Appearance.FocusedRow.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridViewHangHoa.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridViewHangHoa.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridViewHangHoa.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewHangHoa.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewHangHoa.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewHangHoa.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewHangHoa.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewHangHoa.Appearance.Row.Options.UseFont = true;
            this.gridViewHangHoa.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridViewHangHoa.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewHangHoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridViewHangHoa.ColumnPanelRowHeight = 30;
            this.gridViewHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9});
            this.gridViewHangHoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "AlertTon";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.Red;
            formatConditionRuleValue1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
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
            this.gridViewHangHoa.GroupCount = 1;
            this.gridViewHangHoa.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "Số Lượng ={0}")});
            this.gridViewHangHoa.Name = "gridViewHangHoa";
            this.gridViewHangHoa.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewHangHoa.OptionsBehavior.Editable = false;
            this.gridViewHangHoa.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewHangHoa.OptionsView.ShowAutoFilterRow = true;
            this.gridViewHangHoa.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewHangHoa.OptionsView.ShowGroupPanel = false;
            this.gridViewHangHoa.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn9, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewHangHoa.DoubleClick += new System.EventHandler(this.gridViewHangHoa_DoubleClick);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày";
            this.gridColumn3.FieldName = "NgayLap";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn2.Caption = "Tên Hàng";
            this.gridColumn2.FieldName = "TenHang";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 285;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.gridColumn5.Caption = "Đơn Giá";
            this.gridColumn5.DisplayFormat.FormatString = "n0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "DonGia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 175;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "IMEI";
            this.gridColumn1.FieldName = "IMEI";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 223;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Id";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Xuất/Nhập";
            this.gridColumn4.FieldName = "LoaiPhieu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 163;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "LoaiDonHang";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "gridColumn8";
            this.gridColumn8.FieldName = "DonHangId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "gridColumn9";
            this.gridColumn9.FieldName = "NgayLap";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // UcTheKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcTheKho";
            this.Size = new System.Drawing.Size(1854, 1211);
            this.DoubleClick += new System.EventHandler(this.gridViewHangHoa_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlHangHoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnNhapKhoLoc;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;

    }
}
