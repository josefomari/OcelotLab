using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Repositories
{
    public interface IMovieRepository
    {
        public Task<List<Movie>> GetAllMovies();
        public Task<Movie> AddMovie(Movie movie);
    }
}
