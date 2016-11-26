using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public static class PrimitiveConvert
    {
        public static long StringToInt(string item, long valueDefault = 0)
        {
            item= item.Replace(",", "");
            Int64.TryParse(item, out valueDefault);
            return valueDefault;
        }

        public static long StringToInt(object item, long valueDefault = 0)
        {
            item = item.ToString().Replace(",", "");
            Int64.TryParse(item.ToString(), out valueDefault);
            return valueDefault;
        }

        public static float? StringToFloat(object item, float valueDefault = 0)
        {
            item = item.ToString().Replace(",", "");
            float.TryParse(item.ToString(), out valueDefault);
            return valueDefault;
        }

        public static float StringToFloat(string item, float valueDefault = 0)
        {
            item = item.Replace(",", "");
            float.TryParse(item, out valueDefault);
            return valueDefault;
        }

        public static T StringToEnum<T>(string item) where T : struct, IConvertible
        {
            T result = default(T);
            Enum.TryParse<T>(item, out result);
            return result;
        }
    }
}
