using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitCurrency
    {
        /// <summary>
        /// Currency identifier. In the future, the description will simply use the currency
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Currency full name
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Is currency belongs to blockchain (false for ICO and fiat, like EUR)
        /// </summary>
        [JsonProperty("crypto")]
        public bool Crypto { get; set; }
        
        /// <summary>
        /// Is allowed for deposit (false for ICO)
        /// </summary>
        [JsonProperty("payinEnabled")]
        public bool PayingEnabled { get; set; }

        /// <summary>
        /// Is required to provide additional information other than the address for deposit
        /// </summary>
        [JsonProperty("payinPaymentId")]
        public bool PayingPaymentId { get; set; }

        /// <summary>
        /// Blocks confirmations count for deposit
        /// </summary>
        [JsonProperty("payinConfirmations")]
        public int PayingConfirmations { get; set; }

        /// <summary>
        /// Is allowed for withdraw (false for ICO)
        /// </summary>
        [JsonProperty("payoutEnabled")]
        public bool PayoutEnabled { get; set; }

        /// <summary>
        /// Is allowed to provide additional information for withdraw
        /// </summary>
        [JsonProperty("payoutIsPaymentId")]
        public bool PayoutIsPaymentId { get; set; }

        /// <summary>
        /// Is allowed to transfer between trading and account (may be disabled on maintain)
        /// </summary>
        [JsonProperty("transferEnabled")]
        public bool TransferEnabled { get; set; }
        
        /// <summary>
        /// True if currency delisted (stopped deposit and trading)
        /// </summary>
        [JsonProperty("delisted")]
        public bool Delisted { get; set; }

        /// <summary>
        /// Default withdraw fee
        /// </summary>
        [JsonProperty("payoutFee")]
        public decimal PayoutFee { get; set; }

        public override string ToString() => $"{this.Id} | {this.FullName}{(this.Delisted ? " | Delisted" : string.Empty)}";
    }
}