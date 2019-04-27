using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public class KhachHangViewModel
    {
    }

    public partial class KhachHang
    {
        public long No
        {
            get { return CongNoes.Sum(s => s.No); }
        }

        public long ThanhToan
        {
            get { return CongNoes.Sum(s => s.ThanhToan); }
        }

        public DateTime NgayChinhSua{
            get { return TimeHelper.TimeStampToDateTime(CongNoes.Max(s => s.ModifiedDate.GetValueOrDefault())); }
        }

        public long ConLai => No - ThanhToan;
    }
}
