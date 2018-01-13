using Newtonsoft.Json;
using System;

namespace Binance.API.Csharp.Client.Models.General
{
    public class ServerInfo
    {
        [JsonProperty("serverTIme")]
        public long ServerTime { get; set; }

        public DateTime LocalTime
        {
            get => 
                (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(ServerTime).ToLocalTime();
        }

        public DateTime UTCTime
        {

            get =>
                (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds(ServerTime);

        }
    }
}
