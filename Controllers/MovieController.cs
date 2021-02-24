
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Data;
using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        

        public MovieController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpPost]
        public ActionResult<Movie> CreateMovie([FromBody]AddMovie addMovie)
        {
            var movieToCreate = new Movie()
            {
                Title = addMovie.Title,
                Director = addMovie.Director,
                DateCreated = DateTime.Now
            };
            var createdMovie = dbContext.Movies.Add(movieToCreate).Entity;
            dbContext.SaveChanges();
            return createdMovie;
        }

        [HttpPut("{id}")]
        public ActionResult<Movie> EditMovie(int id, [FromBody] EditMovie editMovie)
        {
            var movieToEdit = dbContext.Movies.FirstOrDefault(x => x.MovieId == id);
            if (movieToEdit == null) return NotFound();
            movieToEdit.Title = editMovie.Title;
            movieToEdit.Director = editMovie.Director;
            dbContext.SaveChanges();
            return movieToEdit;
        }

        [HttpDelete("{id}")]
        public ActionResult<Movie> DeleteMovie(int id)
        {
            var movieToDelete = dbContext.Movies.FirstOrDefault(x => x.MovieId == id);
            if (movieToDelete == null) return NotFound();
            dbContext.Movies.Remove(movieToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            var Movies = dbContext.Movies;
            return Movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(int id)
        {
            var Movie = dbContext.Movies.FirstOrDefault(option => option.MovieId == id);
            if (Movie != null)
                return Movie;
            else
                return NotFound();
        }


    }
}
