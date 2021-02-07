using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ApiMarvel.Models
{
	public class Result
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		
		[JsonProperty("title")]
		public string Title { get; set; }
		
		[JsonProperty("description")]
		public object Description { get; set; }

		[JsonProperty("resourceURI")]
		public string ResourceURI { get; set; }

		[JsonProperty("urls")]
		public List<Urls> Urls { get; set; }

		[JsonProperty("startYear")]
		public int StartYear { get; set; }

		[JsonProperty("endYear")]
		public int EndYear { get; set; }

		[JsonProperty("rating")]
		public string Rating { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("modified")]
		public DateTime Modified { get; set; }

		[JsonProperty("thumbnail")]
		public Thumbnail Thumbnail { get; set; }

		[JsonProperty("creators")]
		public Creators Creators { get; set; }

		[JsonProperty("characters")]
		public Characters Characters { get; set; }

		[JsonProperty("stories")]
		public Stories Stories { get; set; }

		[JsonProperty("comics")]
		public Comics Comics { get; set; }

		[JsonProperty("events")]
		public Events Events { get; set; }

		[JsonProperty("next")]
		public object Next { get; set; }

		[JsonProperty("previous")]
		public object Previous { get; set; }
	}
}
