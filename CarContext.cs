using Microsoft.EntityFrameworkCore;

namespace Assignment_10_3_winforms_sqllite;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; } // required for each table... for database context (proxy/wrapper)

    public string DbPath { get; } 

    public CarContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "Cars.db");
        // this tells program where the db file is at
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($"Data Source={DbPath}"); //sets up to use sqllite

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasKey(c => c.Id);

        modelBuilder.Entity<Car>().HasData(
            new Car { Id = 1, VIN = "1FA6P8CF0HXXXXXXX", Make = "Ford", Model = "Mustang", Year = 1980 },
            new Car { Id = 2, VIN = "1G1AY0780AXXXXXXX", Make = "Chevrolet", Model = "Corvette", Year = 1980 },
            new Car { Id = 3, VIN = "JZA8000XXXXXXXXXX", Make = "Toyota", Model = "Celica", Year = 1980 },
            new Car { Id = 4, VIN = "1V4BA31D0BXXXXXXX", Make = "Volkswagen", Model = "Beetle", Year = 1980 },
            new Car { Id = 5, VIN = "WBAAJ51000XXXXXXX", Make = "BMW", Model = "3 Series", Year = 1980 }
        );
    }

}