using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApplication.Models;

namespace MovieApplication.Service
{
    public class MovieService
    {
        private readonly MovieContext _movieContext;
        
        public MovieService(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task SaveMovie(Movie movie)
        {
            _movieContext.Movies.Add(movie);
            await _movieContext.SaveChangesAsync();
        }

        public List<Movie> GetMovies()
        {
            return _movieContext.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _movieContext.Movies.FirstOrDefault(m => m.Id == id);
        }
    }
        
}
