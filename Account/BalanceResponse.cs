using System;
using Newtonsoft.Json;

namespace lbry.net.Account
{
    public class BalanceResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}