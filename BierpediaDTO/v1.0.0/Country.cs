using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class Country : DTOBase {
		public string Name { get; set; }
		public string Description { get; set; }

		public LinksBase _Links { get; set; }

	}

	
}
