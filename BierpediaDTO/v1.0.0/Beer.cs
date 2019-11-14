namespace Bierpedia.DTO {
	public class Beer : DTOBase {
		public string Name { get; set; }
		public string Description { get; set; }
		public Links _Links { get; set; }

		public class Links : LinksBase {
			public string Breweries { get; set; }
			public string BeerTypes { get; set; }
		}
	}

	
}
