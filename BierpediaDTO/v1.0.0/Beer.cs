using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class Beer : DTOBase {
		public string Name { get; set; }
		public string Description { get; set; }

		[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
		public List<Brewery> Breweries { get; set; }

		[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
		public List<BeerType> BeerTypes { get; set; }
		public BeerLinks Links { get; set; }

		public class BeerLinks : LinksBase {
			public string Breweries { get; set; }
			public string BeerTypes { get; set; }
		}
	}

	
}
