using System;
using Newtonsoft.Json;

namespace lbry.net.Account
{
    public class NameResponse
    {
        public String JsonRPC { get; set; }

        [JsonProperty("result")]
        public Object Result { get; set; }
    }
}