using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bierpedia.DTO {
	public class PagedResult<T> where T : DTOBase {
		public int Page { get; set; }

		public int PerPage { get; set; }

		public int TotalPages { get; set; }

		public long Total { get; set; }

		public List<T> Result { get; set; }

		public PageLinks Links { get; set; }

		
		public class PageLinks {
			[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
			public string Previous { get; set; }

			[JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
			public string Next { get; set; }
			public string First { get; set; }
			public string Last { get; set; }
		}
		
	}
}
