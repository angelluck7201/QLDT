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
        public UcCongNoCu(Define.LoaiDonHangEnum loaiDonHang, CongNo data = null)
        {
            InitializeComponent();
            _loaiDonHang = loaiDonHang;
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

            Init(data);
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            var saveData = CRUD.GetFormObject<CongNo>(FormControls);
            CRUD.DecorateSaveData(saveData);
            saveData.LoaiDonHang = _loaiDonHang.ToString();
            CRUD.DbContext.CongNoes.AddOrUpdate(saveData);
            CRUD.DbContext.SaveChanges();

            return true;
        }

        public string ValidateInput()
        {
            return string.Empty;
        }
    }
}
