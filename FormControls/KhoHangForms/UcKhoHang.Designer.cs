namespace QLDT.FormControls.KhoHangForms
{
    partial class UcKhoHang
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
            this.lblTenHang = new System.Windows.Forms.Label();
            this.KhoHang_GhiChu = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.KhoHang_TenHang = new System.Windows.Forms.TextBox();
            this.lblLoaiHangId = new System.Windows.Forms.Label();
            this.KhoHang_LoaiHangId = new System.Windows.Forms.ComboBox();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblTonLyTuong = new System.Windows.Forms.Label();
            this.KhoHang_GiaBan = new DevExpress.XtraEditors.TextEdit();
            this.KhoHang_TonLyTuong = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoHang_GiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoHang_TonLyTuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.Location = new System.Drawing.Point(36, 90);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(84, 19);
            this.lblTenHang.TabIndex = 21;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // KhoHang_GhiChu
            // 
            this.KhoHang_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHang_GhiChu.Location = new System.Drawing.Point(192, 232);
            this.KhoHang_GhiChu.Name = "KhoHang_GhiChu";
            this.KhoHang_GhiChu.Size = new System.Drawing.Size(477, 96);
            this.KhoHang_GhiChu.TabIndex = 4;
            this.KhoHang_GhiChu.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCancel.Location = new System.Drawing.Point(39, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
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
            this.btnSave.Location = new System.Drawing.Point(569, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            // 
            // KhoHang_TenHang
            // 
            this.KhoHang_TenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHang_TenHang.Location = new System.Drawing.Point(192, 85);
            this.KhoHang_TenHang.Name = "KhoHang_TenHang";
            this.KhoHang_TenHang.Size = new System.Drawing.Size(477, 26);
            this.KhoHang_TenHang.TabIndex = 1;
            // 
            // lblLoaiHangId
            // 
            this.lblLoaiHangId.AutoSize = true;
            this.lblLoaiHangId.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiHangId.Location = new System.Drawing.Point(35, 41);
            this.lblLoaiHangId.Name = "lblLoaiHangId";
            this.lblLoaiHangId.Size = new System.Drawing.Size(88, 19);
            this.lblLoaiHangId.TabIndex = 17;
            this.lblLoaiHangId.Text = "Loại Hàng";
            // 
            // KhoHang_LoaiHangId
            // 
            this.KhoHang_LoaiHangId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhoHang_LoaiHangId.FormattingEnabled = true;
            this.KhoHang_LoaiHangId.Location = new System.Drawing.Point(192, 34);
            this.KhoHang_LoaiHangId.Name = "KhoHang_LoaiHangId";
            this.KhoHang_LoaiHangId.Size = new System.Drawing.Size(477, 28);
            this.KhoHang_LoaiHangId.TabIndex = 0;
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBan.Location = new System.Drawing.Point(36, 139);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(71, 19);
            this.lblGiaBan.TabIndex = 24;
            this.lblGiaBan.Text = "Giá Bán";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(36, 237);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 19);
            this.lblGhiChu.TabIndex = 25;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // lblTonLyTuong
            // 
            this.lblTonLyTuong.AutoSize = true;
            this.lblTonLyTuong.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTonLyTuong.Location = new System.Drawing.Point(36, 188);
            this.lblTonLyTuong.Name = "lblTonLyTuong";
            this.lblTonLyTuong.Size = new System.Drawing.Size(122, 19);
            this.lblTonLyTuong.TabIndex = 27;
            this.lblTonLyTuong.Text = "Tồn Lý Tưởng";
            // 
            // KhoHang_GiaBan
            // 
            this.KhoHang_GiaBan.Location = new System.Drawing.Point(192, 135);
            this.KhoHang_GiaBan.Name = "KhoHang_GiaBan";
            this.KhoHang_GiaBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.KhoHang_GiaBan.Properties.Appearance.Options.UseFont = true;
            this.KhoHang_GiaBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.KhoHang_GiaBan.Properties.Mask.EditMask = "n0";
            this.KhoHang_GiaBan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.KhoHang_GiaBan.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.KhoHang_GiaBan.Size = new System.Drawing.Size(477, 28);
            this.KhoHang_GiaBan.TabIndex = 2;
            // 
            // KhoHang_TonLyTuong
            // 
            this.KhoHang_TonLyTuong.Location = new System.Drawing.Point(192, 184);
            this.KhoHang_TonLyTuong.Name = "KhoHang_TonLyTuong";
            this.KhoHang_TonLyTuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.KhoHang_TonLyTuong.Properties.Appearance.Options.UseFont = true;
            this.KhoHang_TonLyTuong.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.KhoHang_TonLyTuong.Properties.Mask.EditMask = "n0";
            this.KhoHang_TonLyTuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.KhoHang_TonLyTuong.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.KhoHang_TonLyTuong.Size = new System.Drawing.Size(477, 28);
            this.KhoHang_TonLyTuong.TabIndex = 3;
            // 
            // UcKhoHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.KhoHang_TonLyTuong);
            this.Controls.Add(this.KhoHang_GiaBan);
            this.Controls.Add(this.lblTonLyTuong);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.KhoHang_LoaiHangId);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.KhoHang_GhiChu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.KhoHang_TenHang);
            this.Controls.Add(this.lblLoaiHangId);
            this.Name = "UcKhoHang";
            this.Size = new System.Drawing.Size(701, 415);
            ((System.ComponentModel.ISupportInitialize)(this.KhoHang_GiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhoHang_TonLyTuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.RichTextBox KhoHang_GhiChu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox KhoHang_TenHang;
        private System.Windows.Forms.Label lblLoaiHangId;
        private System.Windows.Forms.ComboBox KhoHang_LoaiHangId;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblTonLyTuong;
        private DevExpress.XtraEditors.TextEdit KhoHang_GiaBan;
        private DevExpress.XtraEditors.TextEdit KhoHang_TonLyTuong;
    }
}
