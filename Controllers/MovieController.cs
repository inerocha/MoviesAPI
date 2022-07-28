using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        private static int id = 1; 

        [HttpPost]
        public IActionResult IncludeMovie([FromBody] Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);
            return CreatedAtAction(nameof(RecoverMoviesById), new { Id = movie.Id }, movie);
        }

        [HttpGet]  
        public IActionResult RecoverMovies()
        {
            return Ok(movies); 
        }

        [HttpGet("{id}")]
        public IActionResult RecoverMoviesById(int id)
        {
            Movie movie = movies.FirstOrDefault(movie => movie.Id == id);
            if(movie != null)
            {
                return Ok(movie);
            }
            return NotFound(); 
            
        }

    }
}
