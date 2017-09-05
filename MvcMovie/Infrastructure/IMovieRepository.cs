using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcMovie.Model;

namespace MvcMovie.Infrastructure
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMovies();
    }
}
