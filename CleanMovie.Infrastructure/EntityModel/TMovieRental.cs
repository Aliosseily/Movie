using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.EntityModel
{
	public class TMovieRental
	{
		public int Id { get; set; }
		public int RentalId { get; set; }
		public int MovieId { get; set; }
		[JsonIgnore]
		public TRental? Rental { get; set; }
		[JsonIgnore]
		public TMovie? Movie { get; set; }
	}
}
