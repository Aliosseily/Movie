using CleanMovie.Application.Interfaces;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.Services
{
    public class MovieService : IMovieService
	{
		private readonly IMovieRepository _repository;
		public MovieService(IMovieRepository movieRepository)
		{
			_repository= movieRepository;
		}

		public async Task<Movie>CreateMovie(Movie movie)
		{
			await _repository.CreateMovie(movie);
			return movie;
		}

		public async Task<Movie> EditMovie(int id, Movie movie)
		{
			await _repository.EditMovie(id, movie);
			return movie;
		}

		public async Task<List<Movie>> GetAllMovies()
		{
			var result = await _repository.GetAllMovies();
			return result;
		}

		public async Task<Movie> DeleteMovie(int id)
		{
			var result = await _repository.DeleteMovie(id);
			return result;
		}

	}
}
