using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Models
{
    public static class Utilities
    {
        public static DateTime GetLocalTime(long timeOffset) =>
            (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(timeOffset).ToLocalTime();


        public static DateTime GetUTCTime(long timeOffset) =>
            (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(timeOffset);

    }
}
