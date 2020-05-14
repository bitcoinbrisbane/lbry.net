using System;
using Newtonsoft.Json;

namespace lbry.net
{
    public class Response<T>
    {
        public String JsonRPC { get; set; }

        [JsonProperty("result")]
        public T Result { get; set; }
    }
}