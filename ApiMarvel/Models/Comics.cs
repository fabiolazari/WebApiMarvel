using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMarvel.Models
{
	public class Comics
	{
		[JsonProperty("available")]
		public int Available { get; set; }

		[JsonProperty("collectionUri")]
		public string CollectionUri { get; set; }

		[JsonProperty("items")]
		public List<ComicsItem> Items { get; set; }

		[JsonProperty("returned")]
		public int Returned { get; set; }
	}

    public class ComicsItem
	{
		[JsonProperty("resourceUri")]
		public string ResourceUri { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}

