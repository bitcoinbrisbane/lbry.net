using System;
using Newtonsoft.Json;

namespace lbry.net
{
    public class Request
    {
        [JsonProperty("method")]
        public String Method { get; set; }
    }
}
