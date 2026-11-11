using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=PatikaCodeFirstDb2");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(UsersList());
            modelBuilder.Entity<Post>().HasData(PostsList());
        }

        private User[] UsersList()
        {
            return new User[]

            {
                new User { Id = 1, Email = "ali@gmail.com", UserName = "ali" },
                new User { Id = 2, Email = "merve@gmail.com", UserName = "merve" },
                new User { Id = 3, Email = "sinem@gmail.com", UserName = "sinem" }



            };
        }
        private Post[] PostsList()
        {
            return new Post[] {

            new Post { Id = 1, Content = "haber", Title = "ülke gündemi", UserId = 1 },
            new Post { Id = 2, Content = "futbol", Title = "avrupa ligi", UserId = 1 },
            new Post { Id = 3, Content = "magazin", Title = "dümenden haber", UserId = 3},
            new Post { Id = 4, Content = "haber", Title = "ekonomi", UserId = 2 }




            };



        }

    }
}