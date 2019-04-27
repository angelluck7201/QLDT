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

        public UcCongNoList()
        {
            InitializeComponent();

            //ObserverControl.Regist(this.Name, "DefaultForm", Define.ActionTypeEnum.Close, ReloadData);
        }

        public void SetLoaiDonHang(Define.LoaiDonHangEnum loaidDonHang)
        {
            _loaiDonHang = loaidDonHang;
            _loaiKhachHang = _loaiDonHang == Define.LoaiDonHangEnum.NhapKho ? Define.LoaiKhachHangEnum.NhaCungCap : Define.LoaiKhachHangEnum.KhachSi;
            ReloadData();
        }


        private void ReloadData()
        {
            ThreadHelper.LoadForm(() =>
            {
                _khachHangs = CRUD.DbContext.KhachHangs
                    .Where(k => k.LoaiKhachHang == _loaiKhachHang.ToString() && k.CongNoes.Any()).ToList();
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
                    data = CRUD.DbContext.KhachHangs.Find(data.Id);
                    FormBehavior.GenerateForm(new UcCongNo(_loaiDonHang, data), "Công Nợ",
                        this.ParentForm);
                }
            });
        }

        private void btnCongNoLoc_Click(object sender, EventArgs e)
        {
            var startDate = TimeHelper.StringToTimeStamp(CongNo_StartDate.Text);
            var endDate = TimeHelper.StringToTimeStamp(CongNo_EndDate.Text) + TimeHelper.MILISECOND_PER_DAY - 1;
            gridViewCongNo.ActiveFilterString = string.Format("[NgayLap] >= '{0}' AND [NgayLap] <= '{1}'", startDate,
                endDate);
            btnCongNoLoc.Appearance.BackColor = Color.Silver;

        }

        private void btnCongNoHuyLoc_Click(object sender, EventArgs e)
        {
            gridViewCongNo.ActiveFilterString = "";
            btnCongNoLoc.Appearance.BackColor = SystemColors.MenuHighlight;
        }

        private void btnAddCongNo_Click(object sender, EventArgs e)
        {
            FormBehavior.GenerateForm(new UcCongNoCu(Define.LoaiDonHangEnum.NhapKho, _khachHangs), "Công Nợ", this.ParentForm);
        }
    }
}
