using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitOrderBook
    {
        /// <summary>
        /// Array of asks
        /// </summary>
        [JsonProperty("ask")]
        public HitOrderBookLevel[] Asks { get; set; }

        /// <summary>
        /// Array of bids
        /// </summary>
        [JsonProperty("bid")]
        public HitOrderBookLevel[] Bids { get; set; }

        public override string ToString() => $"Asks count: {this.Asks.Length} | Bids count: {this.Bids}";
    }
}