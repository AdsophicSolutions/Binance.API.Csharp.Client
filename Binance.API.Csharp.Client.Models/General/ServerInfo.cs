using Newtonsoft.Json;
using static Binance.API.Csharp.Client.Models.Utilities;

namespace Binance.API.Csharp.Client.Models.General
{
    public class ServerInfo
    {
        [JsonProperty("serverTIme")]
        public long ServerTime { get; set; }

        public System.DateTime ServerTimeLocal { get => GetLocalTime(ServerTime); }
        public System.DateTime ServerTimeUTC { get => GetUTCTime(ServerTime); }
    }
}
