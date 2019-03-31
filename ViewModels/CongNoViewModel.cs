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

        public long DaThanhToan
        {
            get
            {
                var thanhToanDonHang = 0L;
                if (DonHang != null)
                {
                    thanhToanDonHang = DonHang.ThanhToan.GetValueOrDefault();
                }
                var thanhToanCongNo = 0L;
                if (ThanhToanCongNoes != null)
                {
                    thanhToanCongNo = ThanhToanCongNoes.Sum(s => s.ThanhToan.GetValueOrDefault()) - thanhToanDonHang;
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
