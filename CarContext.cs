using System;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10_3_winforms_sqllite;

public class CarContext : DbContext
{
    public DbSet<Car> Cars { get; set; } // required for each table... for database context (proxy/wrapper)
    // expose the car model as a table 'Cars'


    public string DbPath { get; }

    public CarContext()
    {
        // Place the database file in the project directory (source root).
        // AppContext.BaseDirectory is the output folder (bin/Debug/net10.0/...),
        // so go up three levels to reach the project folder and put Cars.db there.
        var projectDir = Path.GetFullPath(Path.Join(AppContext.BaseDirectory, "..", "..", ".."));
        DbPath = Path.Join(projectDir, "Cars.db");
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

} // after this, go to package manager console and conduct MIGRATION by entering command:
// Add-Migration AddProductsTable
