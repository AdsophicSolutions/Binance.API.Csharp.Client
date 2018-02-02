using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Models.Cryptowatch
{
    public class Currency
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("fiat")]
        public bool Fiat { get; set; }
        [JsonProperty("route")]
        public string Route { get; set; }
    }
}
