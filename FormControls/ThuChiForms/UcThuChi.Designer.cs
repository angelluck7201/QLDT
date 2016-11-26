namespace QLDT.FormControls.ThuChiForms
{
    partial class UcThuChi
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
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.ThuChi_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.ThuChi_GhiChu = new System.Windows.Forms.RichTextBox();
            this.ThuChi_Loai = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.ThuChi_SoTien = new DevExpress.XtraEditors.TextEdit();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.ThuChi_NoiDungId = new System.Windows.Forms.ComboBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblNoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ThuChi_SoTien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(30, 33);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(83, 19);
            this.lblNgayLap.TabIndex = 47;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // ThuChi_NgayLap
            // 
            this.ThuChi_NgayLap.CalendarFont = new System.Drawing.Font("Tahoma", 10F);
            this.ThuChi_NgayLap.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ThuChi_NgayLap.Location = new System.Drawing.Point(197, 29);
            this.ThuChi_NgayLap.Name = "ThuChi_NgayLap";
            this.ThuChi_NgayLap.Size = new System.Drawing.Size(420, 28);
            this.ThuChi_NgayLap.TabIndex = 0;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(30, 252);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 19);
            this.lblGhiChu.TabIndex = 45;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // ThuChi_GhiChu
            // 
            this.ThuChi_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuChi_GhiChu.Location = new System.Drawing.Point(197, 248);
            this.ThuChi_GhiChu.Name = "ThuChi_GhiChu";
            this.ThuChi_GhiChu.Size = new System.Drawing.Size(420, 76);
            this.ThuChi_GhiChu.TabIndex = 4;
            this.ThuChi_GhiChu.Text = "";
            // 
            // ThuChi_Loai
            // 
            this.ThuChi_Loai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ThuChi_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThuChi_Loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuChi_Loai.FormattingEnabled = true;
            this.ThuChi_Loai.Location = new System.Drawing.Point(197, 82);
            this.ThuChi_Loai.Name = "ThuChi_Loai";
            this.ThuChi_Loai.Size = new System.Drawing.Size(420, 28);
            this.ThuChi_Loai.TabIndex = 1;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(30, 87);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(108, 19);
            this.lblLoai.TabIndex = 43;
            this.lblLoai.Text = "Loại Thu Chi";
            // 
            // ThuChi_SoTien
            // 
            this.ThuChi_SoTien.Location = new System.Drawing.Point(197, 188);
            this.ThuChi_SoTien.Name = "ThuChi_SoTien";
            this.ThuChi_SoTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ThuChi_SoTien.Properties.Appearance.Options.UseFont = true;
            this.ThuChi_SoTien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ThuChi_SoTien.Properties.Mask.EditMask = "n0";
            this.ThuChi_SoTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ThuChi_SoTien.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ThuChi_SoTien.Size = new System.Drawing.Size(420, 28);
            this.ThuChi_SoTien.TabIndex = 3;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(30, 195);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(101, 19);
            this.lblThanhToan.TabIndex = 48;
            this.lblThanhToan.Text = "Thanh Toán";
            // 
            // ThuChi_NoiDungId
            // 
            this.ThuChi_NoiDungId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ThuChi_NoiDungId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThuChi_NoiDungId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThuChi_NoiDungId.FormattingEnabled = true;
            this.ThuChi_NoiDungId.Location = new System.Drawing.Point(197, 135);
            this.ThuChi_NoiDungId.Name = "ThuChi_NoiDungId";
            this.ThuChi_NoiDungId.Size = new System.Drawing.Size(420, 28);
            this.ThuChi_NoiDungId.TabIndex = 2;
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
            this.btnCancel.Location = new System.Drawing.Point(34, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 6;
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
            this.btnSave.Location = new System.Drawing.Point(471, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Thanh Toán";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDung.Location = new System.Drawing.Point(30, 141);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(82, 19);
            this.lblNoiDung.TabIndex = 49;
            this.lblNoiDung.Text = "Nội Dung";
            // 
            // UcThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ThuChi_NoiDungId);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.ThuChi_NgayLap);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.ThuChi_GhiChu);
            this.Controls.Add(this.ThuChi_Loai);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.ThuChi_SoTien);
            this.Controls.Add(this.lblThanhToan);
            this.Name = "UcThuChi";
            this.Size = new System.Drawing.Size(647, 439);
            ((System.ComponentModel.ISupportInitialize)(this.ThuChi_SoTien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.DateTimePicker ThuChi_NgayLap;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.RichTextBox ThuChi_GhiChu;
        private System.Windows.Forms.ComboBox ThuChi_Loai;
        private System.Windows.Forms.Label lblLoai;
        private DevExpress.XtraEditors.TextEdit ThuChi_SoTien;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.ComboBox ThuChi_NoiDungId;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblNoiDung;
    }
}
