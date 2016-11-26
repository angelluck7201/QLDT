using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class ThuChiViewModel
    {
    }

    public partial class ThuChi
    {
        public string TenNoiDung
        {
            get { return NoiDung.Ten; }
        }

        public DateTime NgayLapFormat
        {
            get { return TimeHelper.TimeStampToDateTime(NgayLap, "d"); }
        }
    }
}
