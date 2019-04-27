using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDT.FormControls.CongNoForms
{
    public partial class UcCongNoCu : BaseUserControl
    {
        private readonly Define.LoaiDonHangEnum _loaiDonHang;
        private List<KhachHang> _khachHangs;
        private CongNo _domainData;
        public UcCongNoCu(Define.LoaiDonHangEnum loaiDonHang, List<KhachHang> khachHangs = null)
        {
            InitializeComponent();
            _domainData = new CongNo();
            _domainData.LoaiDonHang = loaiDonHang.ToString();
            _khachHangs = khachHangs;
            CongNo_KhachHangId.DisplayMember = "Ten";
            CongNo_KhachHangId.ValueMember = "Id";
            var lstKhachHang = new List<KhachHang>();
            if (loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
            {
                lstKhachHang = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang != Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
                lblKhachHangId.Text = "Khách Hàng";
            }
            else
            {
                lstKhachHang = CRUD.DbContext.KhachHangs.Where(s => s.LoaiKhachHang == Define.LoaiKhachHangEnum.NhaCungCap.ToString()).ToList();
            }
            CongNo_KhachHangId.DataSource = new BindingSource((lstKhachHang), null);

            Init(_domainData);
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            CRUD.DecorateSaveData(_domainData);
            CRUD.DbContext.CongNoes.AddOrUpdate(_domainData);
            CRUD.DbContext.SaveChanges();

            if (_khachHangs != null)
            {
                var currentKhachHang = _khachHangs.FirstOrDefault(s => s.Id == _domainData.KhachHangId);
                var khachHang = CRUD.DbContext.KhachHangs.Find(_domainData.KhachHangId);
                if (currentKhachHang == null)
                {
                    _khachHangs.Add(khachHang);
                }
                else
                {
                    currentKhachHang = khachHang;
                }
            }

            return true;
        }

        public string ValidateInput()
        {
            return string.Empty;
        }
    }
}
