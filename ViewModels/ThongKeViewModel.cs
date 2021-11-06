using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class ThongKeViewModel
    {
        public long NoiDungId { get; set; }
        public string NoiDung { get; set; }
        public long SoLuongNhap { get; set; }
        public long SoLuongXuat { get; set; }
        public long Thu { get; set; }
        public long Chi { get; set; }
        public long LoiNhuan { get { return Thu - Chi; } }
        public long LoiNhuanBanHang { get; set; }
        public string Ngay { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public string Quy { get; set; }
        public DateTime NgaySort { get; set; }

        public ThongKeViewModel(ChiTietDonHang donHang)
        {
            NoiDungId = donHang.HangHoaId;
            NoiDung = donHang.TenHangHoa;
            if (donHang.DonHang.LoaiDonHang == Define.LoaiDonHangEnum.NhapKho.ToString())
            {
                SoLuongNhap = (long)donHang.SoLuong;
                Chi = donHang.ThanhTienVND;
            }
            else
            {
                SoLuongXuat = (long)donHang.SoLuong;
                Thu = donHang.ThanhTienVND;
                LoiNhuanBanHang = donHang.LoiNhuan;
            }
            SetThoiGian(donHang.DonHang.NgayLap);
        }

        public ThongKeViewModel(ThuChi thuChi)
        {
            NoiDungId = thuChi.NoiDungId;
            NoiDung = thuChi.TenNoiDung;
            if (thuChi.Loai == Define.LoaiThuChiEnum.Thu.ToString())
            {
                Thu = (long)thuChi.SoTien;
            }
            else
            {
                Chi = (long)thuChi.SoTien;

            }
            SetThoiGian(thuChi.NgayLap);
        }

        private void SetThoiGian(DateTime dateTime)
        {
            Ngay = dateTime.ToShortDateString();
            Thang = string.Format("{0}/{1}", dateTime.Month, dateTime.Year);
            Nam = dateTime.Year.ToString();
            Quy = TimeHelper.TimeStampToQuarter(dateTime);
            NgaySort = dateTime;
        }

        public ThongKeViewModel Clone()
        {
            return this.MemberwiseClone() as ThongKeViewModel;
        }
    }
}
