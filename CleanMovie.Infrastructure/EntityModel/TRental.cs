using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.EntityModel
{
	public class TRental
	{
		[Key]
		public int Id { get; set; }
		public DateTime RentalDate { get; set; }
		public DateTime RentalExpiry { get; set; }
		public decimal TotalCost { get; set; }
		public int MemberId { get; set; }
		[JsonIgnore]
		public TMember? Member { get; set; }
		[JsonIgnore]
		public List<TMovie>? Movies { get; set; } = new List<TMovie>();
	}
}
