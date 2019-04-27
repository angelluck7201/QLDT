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
     
        public long ConLai
        {
            get { return No - ThanhToan; }
        }

        public long ThanhToanNo { get; set; }
    }
}
