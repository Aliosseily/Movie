using CleanMovie.Domain;
using CleanMovie.Infrastructure.EntityModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieDbContext : DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options)
			:base(options)
		{

		}

		public DbSet<TMember>? Members { get; set; }
		public DbSet<TRental>? Rentals { get; set; }
		public DbSet<TMovie>? Movies { get; set; }
		public DbSet<TMovieRental>? MovieRental { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<TRental>()
				.Property(p => p.TotalCost)
				.HasColumnType("decimal(18,2)");

			builder.Entity<TMovie>()
				.Property(p => p.RentalCost)
				.HasColumnType("decimal(18,3)");

		}
	}
}
