using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Interfaces
{
    public interface IMovieRepository
	{
		Task<List<Movie>> GetAllMovies();
		Task<Movie> CreateMovie (Movie movie);
		Task<Movie> EditMovie(int id, Movie movie);
		Task<Movie> DeleteMovie(int id);
	}
}
