using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDT
{
    public static class TimeHelper
    {
        public static long MILISECOND_PER_DAY = 86400000;
        public static long CurrentTimeStamp()
        {
            return DateTimeToTimeStamp(CurentDateTime());
        }

        public static DateTime CurentDateTime()
        {
            return DateTime.UtcNow.AddHours(7);
        }

        public static long DateTimeToTimeStamp(DateTime datetime)
        {
            DateTime baseDate = new DateTime(1970, 1, 1).AddHours(7);
            TimeSpan diff = datetime - baseDate;
            return (long)diff.TotalMilliseconds;
        }

        public static DateTime TimeStampToDateTime(long? time, string format = "G")
        {
            DateTime baseDate = new DateTime(1970, 1, 1).AddMilliseconds(Convert.ToDouble(time)).AddHours(7);
            return baseDate;
        }

        public static long StringToTimeStamp(string time)
        {
            DateTime baseDate = new DateTime(1970, 1, 1).AddHours(7);
            DateTime datetime = Convert.ToDateTime(time);
            TimeSpan diff = datetime - baseDate;
            return (long)diff.TotalMilliseconds;
        }

        public static string TimeStampToQuarter(long? time)
        {
            var dt = TimeStampToDateTime(time);
            return TimeStampToQuarter(dt);
        }

        public static string TimeStampToQuarter(DateTime dt)
        {
            var quarter = 1;
            if (dt.Month >= 4 && dt.Month <= 6)
                quarter = 1;
            else if (dt.Month >= 7 && dt.Month <= 9)
                quarter = 2;
            else if (dt.Month >= 10 && dt.Month <= 12)
                quarter = 3;
            else
                quarter = 4;

            return string.Format("{0}/{1}", quarter, dt.Year);
        }

        public static string TimestampToString(long? time, string format = "G")
        {
            if (time > 0)
            {
                var date = new DateTime(1970, 1, 1).AddMilliseconds(Convert.ToDouble(time)).AddHours(7);
                return date.ToString(format);
            }
            return string.Empty;
        }
    }
}
