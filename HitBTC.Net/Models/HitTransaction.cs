using System;
using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitTransaction
    {
        /// <summary>
        /// Unique identifier for Transaction as assigned by exchange
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Is the internal index value that represents when the entry was updated
        /// </summary>
        [JsonProperty("index")]
        public long Index { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        
        /// <summary>
        /// Transaction amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        
        /// <summary>
        /// Transaction fee
        /// </summary>
        [JsonProperty("fee")]
        public decimal Fee { get; set; }
        
        /// <summary>
        /// Transaction address
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        
        /// <summary>
        /// Transaction payment id
        /// </summary>
        [JsonProperty("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        /// Transaction hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Transaction status. pending, failed, success
        /// </summary>
        [JsonProperty("status")]
        public HitTransactionStatus Status { get; set; }

        /// <summary>
        /// Transaction type. One of: payout - crypto withdraw transaction, payin - crypto deposit transaction, deposit, withdraw, bankToExchange, exchangeToBank
        /// </summary>
        [JsonProperty("type")]
        public HitTransactionType Type { get; set; }
        
        /// <summary>
        /// Date and time when transaction was created
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Transaction last update date and time
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}