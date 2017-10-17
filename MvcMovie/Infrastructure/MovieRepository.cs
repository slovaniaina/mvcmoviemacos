using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcMovie.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MvcMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context = null;

        public MovieRepository(IOptions<Settings> settings)
        {
            _context = new MovieContext(settings);
        }

        public async Task<IEnumerable<Movie>> GetAllMovies()
        {
            return await _context.Movies.Find(_ => true).ToListAsync();
        }

        public async Task SaveMovieAsync(Movie movie){
            await _context.Movies.InsertOneAsync(movie);
        }
    }
}
