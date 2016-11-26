namespace QLDT.FormControls
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navKhoHang = new DevExpress.XtraBars.Navigation.NavButton();
            this.navNhapKho = new DevExpress.XtraBars.Navigation.NavButton();
            this.navXuatKho = new DevExpress.XtraBars.Navigation.NavButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navTheKho = new DevExpress.XtraBars.Navigation.NavButton();
            this.navThuChi = new DevExpress.XtraBars.Navigation.NavButton();
            this.navThongKe = new DevExpress.XtraBars.Navigation.NavButton();
            this.navNguoiDung = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navResetPass = new DevExpress.XtraBars.Navigation.NavButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navKhoHang
            // 
            this.navKhoHang.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.navKhoHang.Caption = "Kho Hàng";
            this.navKhoHang.Name = "navKhoHang";
            this.navKhoHang.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navKhoHang_ElementClick);
            // 
            // navNhapKho
            // 
            this.navNhapKho.Caption = "Nhập Kho";
            this.navNhapKho.Name = "navNhapKho";
            this.navNhapKho.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navNhapKho_ElementClick);
            // 
            // navXuatKho
            // 
            this.navXuatKho.Caption = "Xuất Kho";
            this.navXuatKho.Name = "navXuatKho";
            this.navXuatKho.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navXuatKho_ElementClick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tileNavPane1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainerControl1.Panel2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1058, 585);
            this.splitContainerControl1.SplitterPosition = 39;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.BackColor = System.Drawing.SystemColors.Highlight;
            this.tileNavPane1.Appearance.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.Lavender;
            this.tileNavPane1.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tileNavPane1.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.tileNavPane1.AppearanceHovered.Options.UseBackColor = true;
            this.tileNavPane1.AppearanceHovered.Options.UseFont = true;
            this.tileNavPane1.AppearanceHovered.Options.UseForeColor = true;
            this.tileNavPane1.BackColor = System.Drawing.Color.ForestGreen;
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navKhoHang);
            this.tileNavPane1.Buttons.Add(this.navNhapKho);
            this.tileNavPane1.Buttons.Add(this.navXuatKho);
            this.tileNavPane1.Buttons.Add(this.navTheKho);
            this.tileNavPane1.Buttons.Add(this.navThuChi);
            this.tileNavPane1.Buttons.Add(this.navThongKe);
            this.tileNavPane1.Buttons.Add(this.navNguoiDung);
            this.tileNavPane1.Buttons.Add(this.navResetPass);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(1058, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navTheKho
            // 
            this.navTheKho.Caption = "Thẻ Kho";
            this.navTheKho.Name = "navTheKho";
            this.navTheKho.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navTheKho_ElementClick);
            // 
            // navThuChi
            // 
            this.navThuChi.Caption = "Thu/Chi";
            this.navThuChi.Name = "navThuChi";
            this.navThuChi.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navThuChi_ElementClick);
            // 
            // navThongKe
            // 
            this.navThongKe.Caption = "Thống Kê";
            this.navThongKe.Name = "navThongKe";
            this.navThongKe.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navThongKe_ElementClick);
            // 
            // navNguoiDung
            // 
            this.navNguoiDung.Caption = "Nhân Viên";
            this.navNguoiDung.Name = "navNguoiDung";
            this.navNguoiDung.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navUserAccont_ElementClick);
            // 
            // navButton2
            // 
            this.navButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton2.Caption = "navButton2";
            this.navButton2.Name = "navButton2";
            // 
            // navResetPass
            // 
            this.navResetPass.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navResetPass.Caption = "Thông Tin Người Dùng";
            this.navResetPass.Name = "navResetPass";
            this.navResetPass.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navResetPass_ElementClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 585);
            this.Controls.Add(this.splitContainerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Minh Phát Mobile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavButton navKhoHang;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.NavButton navNhapKho;
        private DevExpress.XtraBars.Navigation.NavButton navXuatKho;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navThongKe;
        private DevExpress.XtraBars.Navigation.NavButton navTheKho;
        private DevExpress.XtraBars.Navigation.NavButton navThuChi;
        private DevExpress.XtraBars.Navigation.NavButton navNguoiDung;
        private DevExpress.XtraBars.Navigation.NavButton navResetPass;

    }
}