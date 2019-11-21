using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class Brewery : DTOBase {
		public string Name { get; set; }
		public BreweryLinks Links { get; set; }

		public class BreweryLinks : LinksBase {

			[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
			public string Country { get; set; }
		}
	}
}
