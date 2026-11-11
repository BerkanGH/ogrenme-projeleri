using Microsoft.EntityFrameworkCore;
using Survivor.Models;

namespace Survivor.Context
{
    public class CompetitorCategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=SurvivorDb;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, Name = "Ünlüler" },
                    new Category { Id = 2, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, Name = "Gönüllüler" }
                );

            modelBuilder.Entity<Competitor>()
                .HasData(
                    new Competitor { Id = 1, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, FirstName = "Acun", LastName = "Ilıcalı", CategoryId = 1 },
                    new Competitor { Id = 2, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, FirstName = "Ali", LastName = "Koç", CategoryId = 1 },
                    new Competitor { Id = 3, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, FirstName = "Mehmet", LastName = "Türkan", CategoryId = 2 },
                    new Competitor { Id = 4, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, FirstName = "Ahmet", LastName = "Yılmaz", CategoryId = 2 },
                    new Competitor { Id = 5, CreatedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), ModifiedDate = new DateTime(2024, 01, 01, 10, 00, 00, DateTimeKind.Utc).ToUniversalTime(), IsDeleted = false, FirstName = "Dursun", LastName = "Ozbek", CategoryId = 1 }
                );
            base.OnModelCreating(modelBuilder);

        }




    }
}
