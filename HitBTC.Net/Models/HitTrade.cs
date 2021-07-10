using Newtonsoft.Json;
using System;

namespace HitBTC.Net.Models
{
    public class HitTrade
    {
        /// <summary>
        /// Trade id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Trade price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Trade quantity
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Trade side sell or buy
        /// </summary>
        [JsonProperty("side")]
        public HitSide Side { get; set; }

        /// <summary>
        /// Trade timestamp
        /// </summary>
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        public override string ToString() => $"{this.Id} | {this.Timestamp} | {this.Side} | {this.Price} | {this.Quantity}";
    }
}