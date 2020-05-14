using System;
using Newtonsoft.Json;

namespace lbry.net.Account
{
    public partial class Result
    {
        [JsonProperty("available")]
        public string Available { get; set; }

        [JsonProperty("reserved")]
        public string Reserved { get; set; }

        [JsonProperty("reserved_subtotals")]
        public ReservedSubtotals ReservedSubtotals { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public partial class ReservedSubtotals
    {
        [JsonProperty("claims")]
        public string Claims { get; set; }

        [JsonProperty("supports")]
        public string Supports { get; set; }

        [JsonProperty("tips")]
        public string Tips { get; set; }
    }
}