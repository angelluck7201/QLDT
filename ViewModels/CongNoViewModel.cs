using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class CongNoViewModel
    {
    }

    public partial class ThanhToanCongNo
    {
        public DateTime NgayThanhToanFormat
        {
            get { return TimeHelper.TimeStampToDateTime(NgayThanhToan, "d"); }
        }

        public string TenKhachHang
        {
            get { return CongNo.TenKhachHang; }
        }
    }

    public partial class CongNo
    {
        public string TenKhachHang
        {
            get
            {
                if (DonHang != null && DonHang.KhachHang != null)
                {
                    return DonHang.KhachHang.Ten;
                }
                if (KhachHang != null)
                {
                    return KhachHang.Ten;
                }
                return string.Empty;
            }
        }

        public DateTime NgayLapFormat
        {
            get
            {
                if (NgayLap != null)
                {
                    return TimeHelper.TimeStampToDateTime(NgayLap, "d");
                }
                return new DateTime();
            }
        }

        public long DaThanhToan
        {
            get
            {
                var thanhToanDonHang = 0L;
                if (DonHang != null)
                {
                    thanhToanDonHang = (long)DonHang.ThanhToan;
                }
                var thanhToanCongNo = 0L;
                if (ThanhToanCongNoes != null)
                {
                    thanhToanCongNo = (long)ThanhToanCongNoes.Sum(s => s.ThanhToan) - thanhToanDonHang;
                }
                return (long)(thanhToanCongNo);
            }
        }

        public long NoDonHang
        {
            get
            {
                if (DonHang != null)
                {
                    return (long)(DonHang.TongCong - DonHang.ThanhToan);
                }
                else
                {
                    return (long)(No + DaThanhToan);
                }
            }
        }
    }
}
