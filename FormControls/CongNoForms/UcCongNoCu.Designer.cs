namespace QLDT.FormControls.CongNoForms
{
    partial class UcCongNoCu
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
            this.CongNo_No = new DevExpress.XtraEditors.TextEdit();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.CongNo_KhachHangId = new System.Windows.Forms.ComboBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.CongNo_GhiChu = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblKhachHangId = new System.Windows.Forms.Label();
            this.CongNo_NgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CongNo_No.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CongNo_No
            // 
            this.CongNo_No.Location = new System.Drawing.Point(205, 165);
            this.CongNo_No.Name = "CongNo_No";
            this.CongNo_No.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.CongNo_No.Properties.Appearance.Options.UseFont = true;
            this.CongNo_No.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CongNo_No.Properties.Mask.EditMask = "n0";
            this.CongNo_No.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CongNo_No.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.CongNo_No.Size = new System.Drawing.Size(477, 28);
            this.CongNo_No.TabIndex = 2;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(49, 235);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(73, 19);
            this.lblGhiChu.TabIndex = 38;
            this.lblGhiChu.Text = "Ghi Chú";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.Location = new System.Drawing.Point(49, 170);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(71, 19);
            this.lblNo.TabIndex = 37;
            this.lblNo.Text = "Tiền Nợ";
            // 
            // CongNo_KhachHangId
            // 
            this.CongNo_KhachHangId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongNo_KhachHangId.FormattingEnabled = true;
            this.CongNo_KhachHangId.Location = new System.Drawing.Point(205, 33);
            this.CongNo_KhachHangId.Name = "CongNo_KhachHangId";
            this.CongNo_KhachHangId.Size = new System.Drawing.Size(477, 28);
            this.CongNo_KhachHangId.TabIndex = 0;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(49, 105);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(78, 19);
            this.lblNgayLap.TabIndex = 36;
            this.lblNgayLap.Text = "Ngày Nợ";
            // 
            // CongNo_GhiChu
            // 
            this.CongNo_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CongNo_GhiChu.Location = new System.Drawing.Point(205, 231);
            this.CongNo_GhiChu.Name = "CongNo_GhiChu";
            this.CongNo_GhiChu.Size = new System.Drawing.Size(477, 96);
            this.CongNo_GhiChu.TabIndex = 3;
            this.CongNo_GhiChu.Text = "";
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
            this.btnCancel.Location = new System.Drawing.Point(52, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 5;
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
            this.btnSave.Location = new System.Drawing.Point(582, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            // 
            // lblKhachHangId
            // 
            this.lblKhachHangId.AutoSize = true;
            this.lblKhachHangId.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangId.Location = new System.Drawing.Point(49, 40);
            this.lblKhachHangId.Name = "lblKhachHangId";
            this.lblKhachHangId.Size = new System.Drawing.Size(105, 19);
            this.lblKhachHangId.TabIndex = 35;
            this.lblKhachHangId.Text = "Khách Hàng";
            // 
            // CongNo_NgayLap
            // 
            this.CongNo_NgayLap.CalendarFont = new System.Drawing.Font("Tahoma", 7.875F);
            this.CongNo_NgayLap.Font = new System.Drawing.Font("Tahoma", 7.875F);
            this.CongNo_NgayLap.Location = new System.Drawing.Point(205, 99);
            this.CongNo_NgayLap.Name = "CongNo_NgayLap";
            this.CongNo_NgayLap.Size = new System.Drawing.Size(477, 28);
            this.CongNo_NgayLap.TabIndex = 1;
            // 
            // UcCongNoCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.CongNo_NgayLap);
            this.Controls.Add(this.CongNo_No);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.CongNo_GhiChu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblKhachHangId);
            this.Controls.Add(this.CongNo_KhachHangId);
            this.Name = "UcCongNoCu";
            this.Size = new System.Drawing.Size(727, 437);
            ((System.ComponentModel.ISupportInitialize)(this.CongNo_No.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit CongNo_No;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.ComboBox CongNo_KhachHangId;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.RichTextBox CongNo_GhiChu;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label lblKhachHangId;
        private System.Windows.Forms.DateTimePicker CongNo_NgayLap;
    }
}
