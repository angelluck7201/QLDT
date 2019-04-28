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
        public UcCongNoCu(Define.LoaiDonHangEnum loaiDonHang, Define.LoaiTienTeEnum loaiTienTe)
        {
            InitializeComponent();
  
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

            CongNo_LoaiTienTe.DisplayMember = "Value";
            CongNo_LoaiTienTe.ValueMember = "Key";
            CongNo_LoaiTienTe.DataSource = new BindingSource(Define.LoaiTienTeDict, null);

            _domainData = new CongNo();
            _domainData.NgayLap = TimeHelper.CurentDateTime();
            _domainData.LoaiDonHang = loaiDonHang.ToString();
            _domainData.LoaiTienTe = loaiTienTe.ToString();

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

            ReturnObject = _domainData.KhachHang;

            return true;
        }

        public string ValidateInput()
        {
            return string.Empty;
        }

        private void lblLoaiTienTe_Click(object sender, EventArgs e)
        {

        }

        private void DonHang_LoaiTienTe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
