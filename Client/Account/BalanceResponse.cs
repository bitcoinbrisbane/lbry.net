using System;
using Newtonsoft.Json;

namespace lbry.net.Account
{
    [Obsolete]
    public class BalanceResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("result")]
        public Balance.Result Result { get; set; }
    }
}