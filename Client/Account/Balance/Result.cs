using System;
using Newtonsoft.Json;

namespace lbry.net.Account.Balance
{
    public class Result
    {
        [JsonProperty("available")]
        public Decimal Available { get; set; }

        [JsonProperty("reserved")]
        public Decimal Reserved { get; set; }

        [JsonProperty("reserved_subtotals")]
        public ReservedSubtotals ReservedSubtotals { get; set; }

        [JsonProperty("total")]
        public Decimal Total { get; set; }
    }

    public class ReservedSubtotals
    {
        [JsonProperty("claims")]
        public string Claims { get; set; }

        [JsonProperty("supports")]
        public string Supports { get; set; }

        [JsonProperty("tips")]
        public Decimal Tips { get; set; }
    }
}