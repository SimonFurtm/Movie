using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
	public class APIController : Controller
	{
		private readonly MvcMovieContext _context;

		public APIController(MvcMovieContext context)
		{
			_context = context;
		}

		[HttpGet]
		// GET: Movies
		public IQueryable<Movie> Index(string movieGenre, string searchString)
		{
			// Use LINQ to get list of genres.
			IQueryable<string> genreQuery = from m in _context.Movie
											orderby m.Genre
											select m.Genre;
			var movies = from m in _context.Movie
						 select m;

			return movies;
		}
	}
}
