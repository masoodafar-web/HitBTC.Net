using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitOrderBookLevel
    {
        /// <summary>
        /// Level price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Level size
        /// </summary>
        [JsonProperty("size")]
        public decimal Size { get; set; }

        public override string ToString() => $"Price: {this.Price} | Size: {this.Size}";
    }
}