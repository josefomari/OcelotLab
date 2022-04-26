using Microsoft.AspNetCore.Mvc;
using Movie.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;
        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllUsers()
        {
            return await _movieRepository.GetAllMovies();
        }

        [HttpPost]
        public async Task<ActionResult<Movie>> AddMovie(Movie movie)
        {
            return await _movieRepository.AddMovie(movie);
        }
    }
}
