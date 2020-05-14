using System;
using Newtonsoft.Json;

namespace lbry.net
{
    public class Response
    {
        public String JsonRPC { get; set; }

        [JsonProperty("result")]
        public Object Result { get; set; }
    }
}
