using CleanMovie.Application.Interfaces;
using CleanMovie.Application.Services;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
	public class MoviesController : BaseApiController
	{
		private readonly IMovieService _service;
		public MoviesController(IMovieService service )
		{
			_service = service;
		}

		[HttpGet]
		public async Task<ActionResult<List<Movie>>> GetAll()
		{ 
			var movies = await _service.GetAllMovies();
			return Ok(movies);
		}

		[HttpPost]
		public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
		{
			var createdMovie = await _service.CreateMovie(movie);
			return Ok(createdMovie);
		}

		[HttpPut]
		public async Task<ActionResult<Movie>> EditMovie(int id, Movie movie)
		{
			var editedMovie = await _service.EditMovie(id, movie);
			return Ok(editedMovie);
		}

		[HttpDelete]
		public async Task<ActionResult<Movie>> DeleteMovie(int id)
		{
			var deletedMovie = await _service.DeleteMovie(id);
			return Ok(deletedMovie);
		}
	}
}
