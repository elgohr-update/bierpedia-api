using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Newtonsoft.Json;

namespace Bierpedia.Api.Model {
	
	public class Beer : Entity {
		
		public decimal ABV { get; set; }

		public int ConcernId { get; set; }
		public virtual Concern Concern { get; set; }  = null!;

		public virtual ICollection<BeerBrewery> BeerBreweries { get; set; }  = null!;

		public virtual ICollection<BeerStyle> BeerStyles { get; set; }  = null!;

		public Beer(string name, string slug, string description) : base(name, slug, description) { } 
	}
}
