using Newtonsoft.Json;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
	public class Marvel
	{
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("attributionText")]
        public string AttributionText { get; set; }
       
        [JsonProperty("attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}