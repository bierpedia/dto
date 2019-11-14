using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class BeerType : DTOBase {
		public string Name { get; set; }
		public string Description { get; set; }

		public Links _Links { get; set; }

		public class Links : LinksBase {

			[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
			public string Parent { get; set; }
		}
	}

	
}
