using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Models.Cryptowatch
{
    public class CurrencyDescriptions
    {
        [JsonProperty("result")]
        public IEnumerable<Currency> Result { get; set; }
    }
}
