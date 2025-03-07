using System;
using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitOrder
    {
        /// <summary>
        /// Unique identifier for Order as assigned by exchange
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Unique identifier for Order as assigned by trader. Uniqueness must be guaranteed within a single trading day, including all active orders.
        /// </summary>
        [JsonProperty("clientOrderId")]
        public string ClientOrderId { get; set; }

        /// <summary>
        /// Trading symbol
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Order side (sell buy)
        /// </summary>
        [JsonProperty("side")]
        public HitSide Side { get;  set; }

        /// <summary>
        /// Order status (new, suspended, partiallyFilled, filled, canceled, expired)
        /// </summary>
        [JsonProperty("status")]
        public HitOrderStatus Status { get;  set; }

        /// <summary>
        /// Order type (limit, market, stopLimit, stopMarket)
        /// </summary>
        [JsonProperty("type")]
        public HitOrderType OrderType { get; set; }

        /// <summary>
        /// Time in force is a special instruction used when placing a trade to indicate how long an order will remain active before it is executed or expires 
        /// GTC - Good till cancel.GTC order won't close until it is filled. 
        /// IOC - An immediate or cancel order is an order to buy or sell that must be executed immediately, and any portion of the order that cannot be immediately filled is cancelled.
        /// FOK - Fill or kill is a type of time-in-force designation used in securities trading that instructs a brokerage to execute a transaction immediately and completely or not at all.
        /// Day - keeps the order active until the end of the trading day in UTC.
        /// GTD - Good till date specified in expireTime.
        /// </summary>
        [JsonProperty("timeInForce")]
        public HitTimeInForce TimeInForce { get; set; }

        /// <summary>
        /// Order quantity
        /// </summary>
        [JsonProperty("quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Order price
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }
        
        /// <summary>
        /// Order stop price
        /// </summary>
        [JsonProperty("avgPrice")]
        public decimal AvgPrice { get; set; }

        /// <summary>
        /// Cumulative executed quantity
        /// </summary>
        [JsonProperty("cumQuantity")]
        public decimal CumulativeQuantity { get; set; }
        
        /// <summary>
        /// Date and time when order was created
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        
        /// <summary>
        /// Last updated order date and time
        /// </summary>
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
        
        /// <summary>
        /// Order expire date. (use for GTD)
        /// </summary>
        [JsonProperty("expireTime")]
        public DateTime ExpireTime { get;set; }
    }
}