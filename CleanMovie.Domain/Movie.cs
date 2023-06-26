using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class Movie
    {
        public string Name { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
        public List<Rental>? Rentals { get; set; } = new List<Rental>();
    }
}
