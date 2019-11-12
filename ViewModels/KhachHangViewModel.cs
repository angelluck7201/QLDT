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
        public string LoaiTienTe { get; set; }

        public long No
        {
            get { return CongNoes.Where(s=>s.IsActived && s.LoaiTienTe == LoaiTienTe).Sum(s => s.No); }
        }

        public long ThanhToan
        {
            get { return CongNoes.Where(s => s.IsActived &&  s.LoaiTienTe == LoaiTienTe).Sum(s => s.ThanhToan); }
        }

        public DateTime NgayChinhSua{
            get { return TimeHelper.TimeStampToDateTime(CongNoes.Where(s => s.IsActived && s.LoaiTienTe == LoaiTienTe).Max(s => s.ModifiedDate.GetValueOrDefault())); }
        }

        public long ConLai {
            get { return No - ThanhToan; }
        }
    }
}
