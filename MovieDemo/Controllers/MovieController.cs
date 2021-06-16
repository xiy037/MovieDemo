using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApplication.Service;
using MovieApplication.Models;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MovieApplication.Controllers
{
    [Route("movies")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly MovieService _movieService;
        private readonly IMapper _mapper;        

        public MovieController(MovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task Post([FromBody] MovieRequest movieRequest)
        {
           var movie = _mapper.Map<Movie>(movieRequest);
           await _movieService.SaveMovie(movie);
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return _movieService.GetMovies();
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(int id)
        {
            var movie = _movieService.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}
