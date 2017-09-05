using System;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcMovie.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MvcMovie.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public Task <IEnumerable<Movie>> Get(){
            var result = GetMovieInternal();
            return result;
        }

        private async Task<IEnumerable<Movie>> GetMovieInternal(){
            return await _movieRepository.GetAllMovies();
        }

	}
}
