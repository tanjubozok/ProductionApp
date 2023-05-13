using Microsoft.EntityFrameworkCore;
using ProductionApp.Entities.Models;
using ProductionApp.Repository.Configurations;
using ProductionApp.Repository.Seeds;

namespace ProductionApp.Repository.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configurations
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new StockConfiguration());

        // seeds
        modelBuilder.ApplyConfiguration(new GroupSeed());
        modelBuilder.ApplyConfiguration(new StockSeed());
    }

    public DbSet<Group> Groups { get; set; }
    public DbSet<Stock> Stocks { get; set; }
}
