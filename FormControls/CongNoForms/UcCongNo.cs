using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace QLDT.FormControls.CongNoForms
{
    public partial class UcCongNo : BaseUserControl
    {

        private readonly CongNo _domainData;
        private readonly List<ChiTietDonHang> _chiTietDonHangs = new List<ChiTietDonHang>();
        private readonly List<ThanhToanCongNo> _thanhToanCongNoes = new List<ThanhToanCongNo>();
        private readonly List<CongNo> _congNoes = new List<CongNo>();
        private readonly Define.LoaiDonHangEnum _loaiDonHang;

        public UcCongNo(Define.LoaiDonHangEnum loaiDonHang, CongNo data)
        {
            InitializeComponent();

            Init(data);
            _domainData = data;
            _loaiDonHang = loaiDonHang;

            if (loaiDonHang == Define.LoaiDonHangEnum.XuatKho)
            {
                lblKhachHangId.Text = "Khách Hàng";
            }

            ThanhToanCongNo_NgayThanhToan.Text = TimeHelper.TimestampToString(TimeHelper.CurrentTimeStamp());

            // Khoi tao thong tin khach hang
            KhachHang.Text = data.KhachHang.Ten;
            NgayLap.Text = TimeHelper.TimestampToString(data.NgayLap);

            if (data.DonHang != null)
            {
                var donHang = data.DonHang;
                TongCong.Text = donHang.TongCong.ToString();

                // Thong tin don hang 
                _chiTietDonHangs = donHang.ChiTietDonHangs.ToList();
                gridControlChiTiet.DataSource = _chiTietDonHangs;
            }

            // Lich su thanh toan
            _thanhToanCongNoes = data.ThanhToanCongNoes.ToList();
            gridControlNhatKy.DataSource = _thanhToanCongNoes;

            // Lich su cong no
            _congNoes = data.KhachHang.CongNoes.Where(s => s.No > 0).ToList();
            gridControlCongNo.DataSource = _congNoes;
        }

        public override bool SaveData()
        {
            var validateResult = ValidateInput();
            if (!string.IsNullOrEmpty(validateResult))
            {
                MessageBox.Show(validateResult);
                return false;
            }

            var thanhToan = PrimitiveConvert.StringToInt(ThanhToanCongNo_ThanhToan.Text);
            var no = PrimitiveConvert.StringToInt(CongNo_No.Text);
            using (var transaction = new TransactionScope())
            {
                if (thanhToan > no)
                {
                    foreach (var congNo in _congNoes)
                    {
                        CRUD.DecorateSaveData(congNo);
                        var tienThanhToan = thanhToan;
                        if (congNo.No >= thanhToan)
                        {
                            thanhToan = 0;
                        }
                        else
                        {
                            tienThanhToan = (long)congNo.No;
                            thanhToan -= (long)congNo.No;
                        }
                        congNo.No -= tienThanhToan;

                        var thanhToanCongNo = CRUD.GetFormObject<ThanhToanCongNo>(FormControls);
                        thanhToanCongNo.ThanhToan = tienThanhToan;
                        thanhToanCongNo.CongNoId = congNo.Id;
                        CRUD.DecorateSaveData(thanhToanCongNo);
                        CRUD.DbContext.ThanhToanCongNoes.Add(thanhToanCongNo);


                        if (thanhToan <= 0) break;
                    }
                    CRUD.DbContext.SaveChanges();
                }
                else
                {

                    // Update cong no
                    var congNo = CRUD.GetFormObject<CongNo>(FormControls);
                    congNo.DonHangId = _domainData.DonHangId;
                    congNo.KhachHangId = _domainData.KhachHangId;
                    congNo.NgayLap = _domainData.NgayLap;
                    congNo.LoaiDonHang = _loaiDonHang.ToString();
                    CRUD.DecorateSaveData(congNo, _domainData);
                    UpdateCongNo(congNo);
                }

                transaction.Complete();
            }

            return true;
        }

        private void UpdateCongNo(CongNo congNo)
        {
            var thanhToan = PrimitiveConvert.StringToInt(ThanhToanCongNo_ThanhToan.Text);
            var no = PrimitiveConvert.StringToInt(CongNo_No.Text);
            congNo.No = Math.Max(no - thanhToan, 0);
            CRUD.DbContext.CongNoes.AddOrUpdate(congNo);

            // Update chi tiet cong no
            var thanhToanCongNo = CRUD.GetFormObject<ThanhToanCongNo>(FormControls);
            if (thanhToanCongNo.ThanhToan > 0)
            {
                thanhToanCongNo.CongNoId = congNo.Id;
                CRUD.DecorateSaveData(thanhToanCongNo);
                CRUD.DbContext.ThanhToanCongNoes.Add(thanhToanCongNo);
            }

            CRUD.DbContext.SaveChanges();
        }

        public string ValidateInput()
        {
            if (string.IsNullOrEmpty(ThanhToanCongNo_ThanhToan.Text))
            {
                return string.Format("Không được phép để trống {0}!", lblThanhToan.Text);
            }
            var thanhToan = PrimitiveConvert.StringToInt(ThanhToanCongNo_ThanhToan.Text);
            var no = PrimitiveConvert.StringToInt(CongNo_No.Text);
            if (thanhToan <= 0)
            {
                return string.Format("Chưa nhập {0}!", lblThanhToan.Text);
            }
            if (thanhToan > no)
            {
                var tongNo = _congNoes.Sum(s => s.No);
                if (thanhToan > tongNo)
                {
                    return "Số tiền thanh toán lớn hơn số tiền nợ!";
                }
            }

            return string.Empty;
        }
    }
}
