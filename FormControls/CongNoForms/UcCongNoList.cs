using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLDT.FormControls.CongNoForms
{
    public partial class UcCongNoList : UserControl
    {
        private List<KhachHang> _khachHangs = new List<KhachHang>();
        private Define.LoaiDonHangEnum _loaiDonHang;
        private Define.LoaiKhachHangEnum _loaiKhachHang;
        private Define.LoaiTienTeEnum _loaiTienTe;
        private bool _isFiltering = false;

        public UcCongNoList()
        {
            InitializeComponent();

            CongNo_EndDate.Value = TimeHelper.CurentDateTime();
            CongNo_StartDate.Value = CongNo_EndDate.Value.AddYears(-1);

            FilterCongNo();

        }

        public void SetLoaiDonHang(Define.LoaiDonHangEnum loaidDonHang, Define.LoaiTienTeEnum loaiTienTe)
        {
            _loaiDonHang = loaidDonHang;
            _loaiTienTe = loaiTienTe;
            _loaiKhachHang = _loaiDonHang == Define.LoaiDonHangEnum.NhapKho ? Define.LoaiKhachHangEnum.NhaCungCap : Define.LoaiKhachHangEnum.KhachSi;
            ReloadData();
        }

        private void RefreshData(object data)
        {
            if (data is KhachHang)
            {
                FormBehavior.RefreshGrid(gridViewCongNo, (KhachHang)data);
            }
        }

        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                CRUD.DisposeDb();
                var startDate = CongNo_StartDate.Value;
                var endDate = CongNo_EndDate.Value;
                _khachHangs = CRUD.DbContext.KhachHangs
                    .Where(k => k.LoaiKhachHang == _loaiKhachHang.ToString() 
                        && k.CongNoes.Any(s=>s.LoaiTienTe == _loaiTienTe.ToString()
                                            && s.NgayLap >= startDate 
                                            && s.NgayLap <= endDate)).ToList();

                _khachHangs.ForEach(s=>s.LoaiTienTe = _loaiTienTe.ToString());
                gridControlCongNo.DataSource = _khachHangs;
            });
        }

        private void gridViewCongNo_DoubleClick(object sender, EventArgs e)
        {
            ThreadHelper.LoadForm(() =>
            {
                var data = (KhachHang) gridViewCongNo.GetRow(gridViewCongNo.FocusedRowHandle);
                if (data != null)
                {
                    ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, RefreshData);
                    data = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcCongNo(_loaiDonHang, _loaiTienTe, data), "Công Nợ",
                        this.ParentForm,
                        this.Name);
                }
            });
        }

        private void btnCongNoLoc_Click(object sender, EventArgs e)
        {
            ReloadData();
            FilterCongNo();
        }

        private void btnAddCongNo_Click(object sender, EventArgs e)
        {
            ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, RefreshData);
            FormBehavior.GenerateForm(new UcCongNoCu(_loaiDonHang, _loaiTienTe), "Công Nợ", this.ParentForm, this.Name);
        }

        private void chkNoOnly_CheckStateChanged(object sender, EventArgs e)
        {
            FilterCongNo();
        }

        private void FilterCongNo()
        {
            gridViewCongNo.ActiveFilterString = "1=1";
            //if (_isFiltering)
            //{
            //    var startDate = TimeHelper.StringToTimeStamp(CongNo_StartDate.Text);
            //    var endDate = TimeHelper.StringToTimeStamp(CongNo_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            //    gridViewCongNo.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate, endDate);
            //}

            if (chkNoOnly.Checked)
            {
                gridViewCongNo.ActiveFilterString += "AND [ConLai] > 0";
            }
        }
    }
}
