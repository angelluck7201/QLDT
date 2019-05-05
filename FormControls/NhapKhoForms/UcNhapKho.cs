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
        private List<ThanhToanCongNo> _thanhToanCongNoes = new List<ThanhToanCongNo>();
        private Define.LoaiDonHangEnum _loaiDonHang;
        private Define.LoaiKhachHangEnum _loaiKhachHang;

        public UcNhapKho(Define.LoaiDonHangEnum loaiDonHang)
        {
            _loaiDonHang = loaiDonHang;
            _loaiKhachHang = _loaiDonHang == Define.LoaiDonHangEnum.XuatKho
                                       ? Define.LoaiKhachHangEnum.KhachSi
                                       : Define.LoaiKhachHangEnum.NhaCungCap;
            InitializeComponent();
            InitAuthorize();
            ReloadData();

            if (_loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
            {
                btnAddPNK.Text = "Xuất Kho";
                tabNhaCungCap.Text = "Khách Hàng";
                tabNhapKho.Text = "Xuất Kho";
                tabCongNo.Text = "Công Nợ Xuất Kho";
            }

            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, RefreshData);
        }

        private void InitAuthorize()
        {
            var feature = _loaiDonHang == Define.LoaiDonHangEnum.XuatKho
                ? Define.FeatureEnum.XuatKho
                : Define.FeatureEnum.NhapKho;
            if (!Authorization.IsHavePermission(feature.ToString(), Define.PermissionEnum.Write.ToString()))
            {
                btnAddNhaCungCap.Visible = false;
                btnAddPNK.Visible = false;
            }
        }

        private void RefreshData(object data)
        {
            if (data is DonHang)
            {
                FormBehavior.RefreshGrid(gridViewNhapKho, (DonHang)data);
            }
            if (data is KhachHang)
            {
                FormBehavior.RefreshGrid(gridViewKhachHang, (KhachHang)data);
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                if (tabControl.SelectedTabPage == tabNhaCungCap)
                {
                    _khachHangs = CRUD.DbContext.KhachHangs.Where(s => s.IsActived && s.LoaiKhachHang == _loaiKhachHang.ToString()).ToList();
                    gridControlKhachHang.DataSource = _khachHangs;
                }

                if (tabControl.SelectedTabPage == tabNhapKho)
                {
                    _donHangs =
                        CRUD.DbContext.DonHangs
                        .Where(s => s.IsActived && s.LoaiDonHang == _loaiDonHang.ToString())
                            .ToList();
                    gridControlNhapKho.DataSource = _donHangs;
                }

                if (tabControl.SelectedTabPage == tabCongNo)
                {
                    ucCongNoList1.SetLoaiDonHang(_loaiDonHang, Define.LoaiTienTeEnum.VND);
                }

                if(tabControl.SelectedTabPage == tabCongNoUSD)
                {
                    ucCongNoList2.SetLoaiDonHang(_loaiDonHang, Define.LoaiTienTeEnum.USD);
                }

                if (tabControl.SelectedTabPage == tabThanhToan)
                {
                    _thanhToanCongNoes = CRUD.DbContext.ThanhToanCongNoes
                                            .Where(s => s.IsActived 
                                                        && s.CongNo.IsActived
                                                        && s.CongNo.LoaiDonHang == _loaiDonHang.ToString()).ToList();
                    gridControlThanhToan.DataSource = _thanhToanCongNoes;
                }
            });
        }

        private void btnAddNhaCungCap_Click(object sender, EventArgs e)
        {
            var title = _loaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap ? "Nhà Cung Cấp" : "Khách Hàng";
            FormBehavior.GenerateForm(new UcKhachHang(_loaiKhachHang), title, this.ParentForm);
        }

        private void gridViewKhachHang_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                var data = _khachHangs[gridViewKhachHang.GetFocusedDataSourceRowIndex()];
                if (data != null)
                {
                    var title = _loaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap ? "Nhà Cung Cấp" : "Khách Hàng";

                    data = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcKhachHang(_loaiKhachHang, data), title, this.ParentForm);
                }
            });
        }

        private void btnAddPNK_Click(object sender, EventArgs e)
        {
            var title = _loaiDonHang == Define.LoaiDonHangEnum.NhapKho ? "Nhập Kho" : "Xuất Kho";
            FormBehavior.GenerateForm(new UcDonHang(_loaiDonHang), title, this.ParentForm);
        }

        private void gridViewNhapKho_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                var data = (DonHang)gridViewNhapKho.GetRow(gridViewNhapKho.FocusedRowHandle);
                if (data != null)
                {
                    var title = _loaiDonHang == Define.LoaiDonHangEnum.NhapKho ? "Nhập Kho" : "Xuất Kho";

                    data = CRUD.DbContext.DonHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcDonHang(_loaiDonHang, data), title, this.ParentForm);
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

        private void tabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            ReloadData();
        }
    }
}
