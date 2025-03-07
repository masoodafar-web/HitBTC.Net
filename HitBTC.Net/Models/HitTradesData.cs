﻿using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitTradesData
    {
        /// <summary>
        /// Array of trades
        /// </summary>
        [JsonProperty("data")]
        public HitTrade[] Data { get; set; }
        
        /// <summary>
        /// Trades symbol name
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}