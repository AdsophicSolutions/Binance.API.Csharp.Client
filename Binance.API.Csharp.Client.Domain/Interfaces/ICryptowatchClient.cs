using Binance.API.Csharp.Client.Models.Cryptowatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Domain.Interfaces
{
    public interface ICryptowatchClient
    {
        Task<CurrencyDescriptions> GetCurrencyDescriptions();         
    }
}
