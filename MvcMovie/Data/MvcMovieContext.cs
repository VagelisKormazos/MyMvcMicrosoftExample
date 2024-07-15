using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        //A DbSet<TEntity> can be used to query and save instances of TEntity
        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
