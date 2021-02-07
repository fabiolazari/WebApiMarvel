using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
	public class Stories
    {
        [JsonProperty("available")]
        public int Available { get; set; }
        
        [JsonProperty("collectionUri")]
        public string CollectionUri { get; set; }
        
        [JsonProperty("items")]
        public List<StoriesItem> Items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }

    public class StoriesItem
	{
        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
	}
}
