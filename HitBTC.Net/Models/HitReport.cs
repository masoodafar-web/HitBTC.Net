﻿using Newtonsoft.Json;

namespace HitBTC.Net.Models
{
    public class HitReport : HitOrder
    {
        /// <summary>
        /// Describes what kind of report it is
        /// </summary>
        [JsonProperty("reportType")]
        public HitReportType ReportType { get;  set; }

        /// <summary>
        /// Required for reportType = trade. Trade Id.
        /// </summary>
        [JsonProperty("tradeId")]
        public long TradeId { get;  set; }

        /// <summary>
        /// Required for reportType = trade. Quantity of trade.
        /// </summary>
        [JsonProperty("tradeQuantity")]
        public decimal TradeQuantity { get;  set; }

        /// <summary>
        /// Required for reportType = trade. Trade price.
        /// </summary>
        [JsonProperty("tradePrice")]
        public decimal TradePrice { get;  set; }

        /// <summary>
        /// Required for reportType = trade. Fee paid for trade.
        /// </summary>
        [JsonProperty("tradeFee")]
        public decimal TradeFee { get; set; }

        /// <summary>
        /// Identifier of replaced order.
        /// </summary>
        [JsonProperty("originalRequestClientOrderId")]
        public string OriginalRequestClientOrderId { get;  set; }
    }
}