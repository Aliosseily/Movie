using System.Text.Json.Serialization;

namespace CleanMovie.Domain
{
    public class MovieRental
    {
        public int Id { get; set; }
        public int RentalId { get; set; }
        public int MovieId { get; set; }
		[JsonIgnore]
		public Rental? Rental { get; set; }
		[JsonIgnore]
		public Movie? Movie { get; set; }
	}
}