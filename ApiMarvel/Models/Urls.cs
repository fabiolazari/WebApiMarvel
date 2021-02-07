using Newtonsoft.Json;

namespace ApiMarvel.Models
{
	public class Urls
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("urls")]
		public string Url { get; set; }
	}
}