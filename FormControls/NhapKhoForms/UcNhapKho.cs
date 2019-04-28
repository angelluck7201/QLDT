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

        public UcNhapKho()
        {
            InitializeComponent();
            InitAuthorize();
            ReloadData();

            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, RefreshData);
        }

        private void InitAuthorize()
        {
            if (!Authorization.IsHavePermission(Define.FeatureEnum.NhapKho.ToString(), Define.PermissionEnum.Write.ToString()))
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
                    _khachHangs = CRUD.DbContext.KhachHangs
                    .Where(s => s.IsActived && s.LoaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
                    gridControlKhachHang.DataSource = _khachHangs;
                }

                if (tabControl.SelectedTabPage == tabNhapKho)
                {
                    _donHangs =
                        CRUD.DbContext.DonHangs
                        .Where(s => s.IsActived && s.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString())
                            .ToList();
                    gridControlNhapKho.DataSource = _donHangs;
                }

                if (tabControl.SelectedTabPage == tabCongNo)
                {
                    ucCongNoList1.SetLoaiDonHang(Define.LoaiDonHangEnum.NhapKho);
                }

                if (tabControl.SelectedTabPage == tabThanhToan)
                {
                    _thanhToanCongNoes = CRUD.DbContext.ThanhToanCongNoes.Where(s => s.IsActived && s.CongNo.IsActived).ToList();
                    gridControlThanhToan.DataSource = _thanhToanCongNoes;
                }
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
                var data = _khachHangs[gridViewKhachHang.GetFocusedDataSourceRowIndex()];
                if (data != null)
                {
                    data = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcKhachHang(Define.LoaiKhachHangEnum.NhaCungCap, data), "Nhà Cung Cấp", this.ParentForm);
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
                var data = (DonHang)gridViewNhapKho.GetRow(gridViewNhapKho.FocusedRowHandle);
                if (data != null)
                {
                    data = CRUD.DbContext.DonHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcDonHang(Define.LoaiDonHangEnum.NhapKho, data), "Nhập Kho", this.ParentForm);
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
