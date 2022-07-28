using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base (opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }

    }
}
