using System;
using Newtonsoft.Json;

namespace lbry.net.Name
{
    public partial class Result
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("address_generator")]
        public AddressGenerator AddressGenerator { get; set; }

        [JsonProperty("certificates")]
        public long Certificates { get; set; }

        [JsonProperty("coins")]
        public double Coins { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("ledger")]
        public string Ledger { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }

        [JsonProperty("satoshis")]
        public long Satoshis { get; set; }
    }

    public partial class AddressGenerator
    {
        [JsonProperty("change")]
        public Change Change { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("receiving")]
        public Change Receiving { get; set; }
    }

    public partial class Change
    {
        [JsonProperty("gap")]
        public long Gap { get; set; }

        [JsonProperty("maximum_uses_per_address")]
        public long MaximumUsesPerAddress { get; set; }
    }
}