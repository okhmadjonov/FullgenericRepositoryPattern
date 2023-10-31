using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        

            public DbSet<Actor> Actors { get; set; }
            public DbSet<Movie> Movies { get; set; }
            public DbSet<Biography> Biographies { get; set; }
            public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                
                  new Actor { Id=1, FirstName="Santino", LastName="Marex" },
                  new Actor { Id = 2, FirstName = "Denzel", LastName = "Washington" },
                  new Actor { Id = 3, FirstName = "John", LastName = "Doe" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "The Old Man and Boy", Description = "This Movie About Sailor and young boy who learns fishing from old man", ActorId=1},
                 new Movie { Id = 2, Name = "The Equalizer", Description = "This Movie About The Man Who helps all ordimnary people", ActorId = 2 },
                  new Movie { Id = 3, Name = "The Teacher", Description = "This Movie About teacher who teaches badboys", ActorId = 3 }
                );
        }

    }
}
