using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binance.API.Csharp.Client.Test
{
    internal class APIKey
    {
        internal static string Key { get; }
        internal static string Secret { get; }

        static APIKey()
        {
            var location = System.Environment.GetEnvironmentVariable("B_API_KEY");
            string [] keyDetails = System.IO.File.ReadAllLines(location);
            Key = keyDetails[0];
            Secret = keyDetails[1];
        }
    }
}
