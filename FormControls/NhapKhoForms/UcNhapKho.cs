using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDT.FormControls.CongNoForms;
using QLDT.FormControls.DonHangForms;
using QLDT.FormControls.KhachHangForms;

namespace QLDT.FormControls.NhapKhoForms
{
    public partial class UcNhapKho : UserControl
    {
        private List<KhachHang> _khachHangs = new List<KhachHang>();
        private List<DonHang> _donHangs = new List<DonHang>();
        private List<CongNo> _congNos = new List<CongNo>();
        private List<ThanhToanCongNo> _thanhToanCongNoes = new List<ThanhToanCongNo>(); 

        public UcNhapKho()
        {
            InitializeComponent();
            InitAuthorize();
            ReloadData();

            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, ReloadData);
        }

        private void InitAuthorize()
        {
            if (!Authorization.IsHavePermission(Define.FeatureEnum.NhapKho.ToString(), Define.PermissionEnum.Write.ToString()))
            {
                btnAddNhaCungCap.Visible = false;
                btnAddPNK.Visible = false;
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();
                _khachHangs = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
                gridControlKhachHang.DataSource = _khachHangs;

                _donHangs = CRUD.DbContext.DonHangs.Where(s => s.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString()).ToList();
                gridControlNhapKho.DataSource = _donHangs;

                _congNos = CRUD.DbContext.CongNoes.Where(s => s.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString()).ToList();
                gridControlCongNo.DataSource = _congNos;

                _thanhToanCongNoes = _congNos.SelectMany(s => s.ThanhToanCongNoes).ToList();
                gridControlThanhToan.DataSource = _thanhToanCongNoes;
            });
        }

        private void btnAddNhaCungCap_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcKhachHang(Define.LoaiKhachHangEnum.NhaCungCap), "Nhà Cung Cấp", this.ParentForm);
        }

        private void gridViewKhachHang_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewKhachHang.GetRow(gridViewKhachHang.FocusedRowHandle);
                if (data != null && data.Id != null)
                {

                    var info = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcKhachHang(Define.LoaiKhachHangEnum.NhaCungCap, info), "Nhà Cung Cấp", this.ParentForm);
                }
            });
        }

        private void btnAddPNK_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcDonHang(Define.LoaiDonHangEnum.NhapKho), "Nhập Kho", this.ParentForm);
        }

        private void gridViewNhapKho_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewNhapKho.GetRow(gridViewNhapKho.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.DonHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcDonHang(Define.LoaiDonHangEnum.NhapKho, info), "Nhập Kho", this.ParentForm);
                }
            });
        }

        private void gridViewCongNo_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                dynamic data = gridViewCongNo.GetRow(gridViewCongNo.FocusedRowHandle);
                if (data != null && data.Id != null)
                {
                    var info = CRUD.DbContext.CongNoes.Find(data.Id);
                    FormBehavior.GenerateForm(new UcCongNo(Define.LoaiDonHangEnum.NhapKho, info), "Công Nợ", this.ParentForm);
                }
            });
        }

        private void btnNhapKhoLoc_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(NhapKho_StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(NhapKho_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewNhapKho.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate, endDate);
            btnNhapKhoLoc.Appearance.BackColor = Color.Silver;
        }

        private void btnNhapKhoBoLoc_Click(object sender, EventArgs e)
        {
            gridViewNhapKho.ActiveFilterString = "";
            btnNhapKhoLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }

        private void btnCongNoLoc_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(CongNo_StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(CongNo_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewCongNo.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate, endDate);
            btnCongNoLoc.Appearance.BackColor = Color.Silver;

        }

        private void btnCongNoHuyLoc_Click(object sender, EventArgs e)
        {
            gridViewCongNo.ActiveFilterString = "";
            btnCongNoLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }

        private void btnAddCongNo_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcCongNoCu(Define.LoaiDonHangEnum.NhapKho), "Công Nợ", this.ParentForm);
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
