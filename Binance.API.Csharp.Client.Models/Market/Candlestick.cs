using static Binance.API.Csharp.Client.Models.Utilities; 

namespace Binance.API.Csharp.Client.Models.Market
{
    public class Candlestick
    {
        public long OpenTime { get; set; }
        public System.DateTime OpenTimeLocal { get => GetLocalTime(OpenTime); }
        public System.DateTime OpenTimeUTC { get => GetUTCTime(OpenTime); }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }                
        public long CloseTime { get; set; }
        public System.DateTime CloseTimeLocal { get => GetLocalTime(CloseTime); }
        public System.DateTime CloseTimeUTC { get => GetUTCTime(CloseTime); }
        public decimal Volume { get; set; }
        public decimal QuoteAssetVolume { get; set; }
        public int NumberOfTrades { get; set; }
        public decimal TakerBuyBaseAssetVolume { get; set; }
        public decimal TakerBuyQuoteAssetVolume { get; set; }
    }
}
