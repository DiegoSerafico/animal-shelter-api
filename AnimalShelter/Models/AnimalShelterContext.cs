using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
      public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
          : base(options)
      {
      }

      public DbSet<Animal> Animals { get; set; }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Animal>()
        .HasData
        (
          new Animal { AnimalId = 1, Name = "Hobbs", Species = "Tiger", Gender = "Male", Age = 4 },
          new Animal { AnimalId = 2, Name = "Scooby-Doo", Species = "Dog", Gender = "Male", Age = 5 },
          new Animal { AnimalId = 3, Name = "Nala", Species = "Tiger", Gender = "Female", Age = 5 },
          new Animal { AnimalId = 4, Name = "Minnie", Species = "Mouse", Gender = "Female", Age = 4 },
          new Animal { AnimalId = 5, Name = "Speedy Gonzales", Species = "Mouse", Gender = "Male", Age = 2 }
        );
      }
    }
}