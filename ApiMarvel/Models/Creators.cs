using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
    public class Creators
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty("items")]
        public List<CreatorsItem> Items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }

    public class CreatorsItem
    {
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

}