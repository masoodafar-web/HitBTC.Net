using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitDepositAddress
    {
        /// <summary>
        /// Address for deposit
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Optional additional parameter. Required for deposit if persist
        /// </summary>
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }
    }
}