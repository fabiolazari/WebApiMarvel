using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
	public class Events
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionUri")]
        public string CollectionUri { get; set; }

        [JsonProperty("items")]
        public List<EventsItem> Items { get; set; }

        [JsonProperty("returned")]
        public int Returned { get; set; }
	}
    public class EventsItem
    {

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }


        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
