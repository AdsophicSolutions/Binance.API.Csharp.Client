using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Models.Market.TradingRules
{
    public class TradingRules
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
        [JsonProperty("serverTime")]
        public long ServerTime { get; set; }
        public DateTime ServerTimeLocal { get => Utilities.GetLocalTime(ServerTime); }
        public DateTime ServerTimeUTC { get => Utilities.GetUTCTime(ServerTime); }
        [JsonProperty("rateLimits")]
        public IEnumerable<RateLimit> RateLimits { get; set; }
        [JsonProperty("symbols")]
        public IEnumerable<Symbol> Symbols { get; set; }
    }
}
