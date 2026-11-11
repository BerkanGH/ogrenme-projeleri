using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres ;Database= PatikaCodeFirstDb1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Genre = "action", ReleaseYear = 2000, Title = "Action Film1" },
                new Movie() { Id = 2, Genre = "fantastic", ReleaseYear = 2000, Title = "fantastic Film1" },
                new Movie() { Id = 3, Genre = "action", ReleaseYear = 2000, Title = "Action Film2" },
                new Movie() { Id = 4, Genre = "drama", ReleaseYear = 2000, Title = "Drama Film1" }
             
                );
            modelBuilder.Entity<Game>().HasData(
                new Game() { Id = 1, Name = "futbol",  Platform = "ucl", Rating = 10 },
                new Game() { Id = 2, Name = "last of us2",  Platform = "ps", Rating = 10 },
                new Game() { Id = 3, Name = "lol",  Platform = "pc", Rating = 0 }
              

                );
        }

    }
}
