using AutoMapper;
using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
	{
		// MovieRepository depends on the MovieDbContext ( dependency injection )
		private readonly MovieDbContext _context;
		private readonly IMapper _mapper;
		public MovieRepository(MovieDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		//List<Movie> movies = new List<Movie>()
		//{
		//	new Movie{ Id=1, Name="Peaky Blinders", Cost=200},
		//	new Movie{ Id=2, Name="Braking Bad", Cost=400}
		//};

		public async Task<Movie> CreateMovie(Movie movie)
		{
			_context.Movies.Add(_mapper.Map<TMovie>(movie));
			await _context.SaveChangesAsync();
			return movie;
		}

		public async Task<List<Movie>> GetAllMovies()
		{
			var movies = await _context.Movies.Include(m => m.Rentals).ToListAsync();
			return _mapper.Map<List<Movie>>(movies);
		}

		public async Task<Movie> EditMovie(int id, Movie movie)
		{
			var movieInDb = await _context.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
			if (movieInDb == null)
			{
				throw new Exception("movie not found");
			}
			_mapper.Map(movie, movieInDb);
			_context.SaveChangesAsync();
			return movie;
		}

		public async Task<Movie> DeleteMovie(int id)
		{
			var movieInDb = await _context.Movies.Where(m => m.Id == id).FirstOrDefaultAsync();
			if (movieInDb == null)
			{
				throw new Exception("movie not found");
			}
			_context.Movies.Remove(movieInDb);
			_context.SaveChangesAsync();
			return _mapper.Map<Movie>(movieInDb);
		}

	}
}
