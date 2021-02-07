using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
	public class Characters
	{
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionUri")]
        public string CollectionUri { get; set; }

        [JsonProperty("items")]
        public List<CharactersItem> Items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
    }

    public class CharactersItem
    {
        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
