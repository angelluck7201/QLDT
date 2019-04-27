using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QLDT.FormControls.CongNoForms;
using QLDT.FormControls.DonHangForms;
using QLDT.FormControls.KhachHangForms;

namespace QLDT.FormControls.XuatKhoForms
{
    public partial class UcXuatKho : UserControl
    {

        private List<KhachHang> _khachHangs = new List<KhachHang>();
        private List<DonHang> _donHangs = new List<DonHang>();
        private List<CongNo> _congNos = new List<CongNo>();
        private List<ThanhToanCongNo> _thanhToanCongNoes = new List<ThanhToanCongNo>(); 

        public UcXuatKho()
        {
            InitializeComponent();
            InitAuthorize();
            ReloadData();

            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, ReloadData);

        }

        private void InitAuthorize()
        {
            if (!Authorization.IsHavePermission(Define.FeatureEnum.XuatKho.ToString(), Define.PermissionEnum.Write.ToString()))
            {
                btnAddNhaCungCap.Visible = false;
                btnAddPXK.Visible = false;
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();

                _khachHangs = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang == Define.LoaiKhachHangEnum.KhachSi.ToString()).ToList();
                gridControlKhachHang.DataSource = _khachHangs;

                _donHangs = CRUD.DbContext.DonHangs.Where(s => s.LoaiDonHang == Define.LoaiDonHangEnum.XuatKho.ToString()).ToList();
                gridControlNhapKho.DataSource = _donHangs;

                _thanhToanCongNoes = _congNos.SelectMany(s => s.ThanhToanCongNoes).ToList();
                gridControlThanhToan.DataSource = _thanhToanCongNoes;

            });
        }

        private void btnAddNhaCungCap_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcKhachHang(Define.LoaiKhachHangEnum.KhachSi), "Khách Hàng", this.ParentForm);
        }

        private void gridViewKhachHang_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewKhachHang.GetRow(gridViewKhachHang.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcKhachHang(Define.LoaiKhachHangEnum.KhachSi, info), "Khách Hàng", this.ParentForm);
                }
            });
        }

        private void btnAddPXK_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcDonHang(Define.LoaiDonHangEnum.XuatKho), "Xuất Kho", this.ParentForm);
        }

        private void gridViewNhapKho_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewXuatKho.GetRow(gridViewXuatKho.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.DonHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcDonHang(Define.LoaiDonHangEnum.XuatKho, info), "Xuất Kho", this.ParentForm);
                }
            });
        }


        private void btnNhapKhoLoc_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(NhapKho_StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(NhapKho_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewXuatKho.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate, endDate);
            btnNhapKhoLoc.Appearance.BackColor = Color.Silver;
        }

        private void btnNhapKhoBoLoc_Click(object sender, EventArgs e)
        {
            gridViewXuatKho.ActiveFilterString = "";
            btnNhapKhoLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }

        private void btnThanhToanLoc_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(ThanhToan_StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(ThanhToan_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewThanhToan.ActiveFilterString = string.Format("[NgayThanhToan] >= '{0}' AND [NgayThanhToan] <= '{1}'", startDate, endDate);
            btnThanhToanLoc.Appearance.BackColor = Color.Silver;

        }

        private void btnThanhToanHuyLoc_Click(object sender, EventArgs e)
        {
            gridViewThanhToan.ActiveFilterString = "";
            btnThanhToanLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }
    }
}
