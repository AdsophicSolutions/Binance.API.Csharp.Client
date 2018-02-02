using Binance.API.Csharp.Client.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Binance.API.Csharp.Client.Models.Cryptowatch;
using Binance.API.Csharp.Client.Utils;
using Binance.API.Csharp.Client.Models.Enums;

namespace Binance.API.Csharp.Client
{
    public class CryptowatchClient : ICryptowatchClient
    {
        ApiClient _apiClient = null; 
        public CryptowatchClient()
        {
            _apiClient = new ApiClient(null, null, EndPoints.CurrencyDescriptions, null, false);
        }

        public async Task<CurrencyDescriptions> GetCurrencyDescriptions()
        {
            var result = await _apiClient.CallAsync<CurrencyDescriptions>(ApiMethod.GET, string.Empty, false);
            return result;
        }
    }
}
