using System.Text.Json.Serialization;

namespace CleanMovie.Domain
{
    public class Rental
    {
        public DateTime RentalDate { get; set; }
        public DateTime RentalExpiry { get; set; }
        public decimal TotalCost { get; set; }
        public int MemberId { get; set; }
        [JsonIgnore]
        public Member? Member { get; set; }
		[JsonIgnore]
		public List<Movie>? Movies { get; set; } = new List<Movie>();
	}
}