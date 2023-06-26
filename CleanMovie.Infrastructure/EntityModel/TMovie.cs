using CleanMovie.Infrastructure.EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Domain
{
    public class TMovie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal RentalCost { get; set; }
        public int RentalDuration { get; set; }
        public List<TRental>? Rentals { get; set; } = new List<TRental>();
    }
}
