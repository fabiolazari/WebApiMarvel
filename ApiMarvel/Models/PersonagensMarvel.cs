using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMarvel.Models
{
	public class PersonagensMarvel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<string> Characters { get; set; }
		public List<string> Stories { get; set; }
		public List<string> Comics { get; set; }
		public List<string> Events { get; set; }
	}
}