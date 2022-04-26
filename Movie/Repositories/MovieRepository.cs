using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly List<Movie> _movies;
        public static MovieRepository Instance;

        public MovieRepository()
        {
            if (Instance == null)
            {
                Instance = this;
                _movies = new List<Movie>();

                _movies.Add(new Movie
                {
                    Id = Guid.NewGuid(),
                    Genre = "Comedy",
                    Name = "Rush Hour",
                    Price = 50
                });

                _movies.Add(new Movie
                {
                    Id = Guid.NewGuid(),
                    Genre = "Comedy",
                    Name = "Rush Hour 2",
                    Price = 50
                });
            }
        }

        public Task<Movie> AddMovie(Movie movie)
        {
            Instance._movies.Add(new Movie
            {
                Id = movie.Id,
                Genre = movie.Genre,
                Name = movie.Name,
                Price = movie.Price
            });
            return Task.FromResult(movie);
        }

        public Task<List<Movie>> GetAllMovies()
        {
            return Task.FromResult(Instance._movies);
        }
    }
}
