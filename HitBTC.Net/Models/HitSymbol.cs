using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitSymbol
    {
        /// <summary>
        /// Symbol identifier. In the future, the description will simply use the symbol
        /// </summary>
        [JsonProperty("id")]
        public string Id { get;  set; }

        /// <summary>
        /// Base currency name
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Quoting currency name
        /// </summary>
        [JsonProperty("quoteCurrency")]
        public string QuoteCurrency { get; set; }

        /// <summary>
        /// Quantity increment
        /// </summary>
        [JsonProperty("quantityIncrement")]
        public decimal QuantityIncrement { get; set; }

        /// <summary>
        /// Tick size (minimum price change)
        /// </summary>
        [JsonProperty("tickSize")]
        public decimal TickSize { get;  set; }

        /// <summary>
        /// Take liquidity rate
        /// </summary>
        [JsonProperty("takeLiquidityRate")]
        public decimal TakeLiquidityRate { get; set; }

        /// <summary>
        /// Provide liquiity rate
        /// </summary>
        [JsonProperty("provideLiquidityRate")]
        public decimal ProvideLiquidityRate { get;  set; }

        /// <summary>
        /// Fee currency name
        /// </summary>
        [JsonProperty("feeCurrency")]
        public string FeeCurrency { get;  set; }

        public override string ToString() => $"{this.Id} | {this.BaseCurrency} | {this.QuoteCurrency}";
    }
}