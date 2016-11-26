using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    class KhoHangViewModel
    {

    }

    public partial class KhoHang
    {
        public string DVT
        {
            get
            {
                var dvt = PrimitiveConvert.StringToEnum<Define.DVTEnum>(this.DonViTinh);
                if (Define.DVTDict.ContainsKey(dvt))
                {
                    return Define.DVTDict[dvt];
                }
                return "";
            }
        }

        public bool IsAlertTon
        {
            get
            {
                return SoLuong <= TonLyTuong;
            }
        }
    }
}
