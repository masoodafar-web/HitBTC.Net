using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitCandleData
    {
        /// <summary>
        /// Array of candles
        /// </summary>
        [JsonProperty("data")]
        public HitCandle[] Data { get; set; }
        
        /// <summary>
        /// Candles symbol name
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        
        /// <summary>
        /// Candles period
        /// </summary>
        [JsonProperty("period")]
        public HitPeriod Period { get; set; }
    }
}