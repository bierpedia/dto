using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class Brewery : DTOBase {
		public string Name { get; set; }
		public Links _Links { get; set; }

		public class Links : LinksBase {

			[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
			public string Country { get; set; }
		}
	}
}
