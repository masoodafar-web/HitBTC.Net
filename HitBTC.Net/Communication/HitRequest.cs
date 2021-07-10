using HitBTC.Net.Models;
using HitBTC.Net.Models.RequestsParameters;
using Newtonsoft.Json;
using System.Threading;

namespace HitBTC.Net.Communication
{
    internal class HitRequest
    {
        [JsonProperty("method")]
        public HitRequestMethod Method { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("params")]
        public HitRequestParameters Params { get; set; }

        private static long requestIdCounter;

        private const char ID_DELIMITER = '_';

        public HitRequest(HitRequestParameters hitRequestParameters)
        {
            this.Params = hitRequestParameters;
            this.Method = hitRequestParameters.HitRequestMethod;
            this.Id = GenerateRequestId(this.Method.ToString());
        }

        public override string ToString() => $"{this.Method} | {this.Params} | Id = {this.Id}";

        private static string GenerateRequestId(string requestType) => $"{requestType}{ID_DELIMITER}{Interlocked.Increment(ref requestIdCounter)}";
    }
}