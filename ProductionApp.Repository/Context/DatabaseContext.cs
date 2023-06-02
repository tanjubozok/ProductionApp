namespace ProductionApp.Repository.Context;

public class DatabaseContext : IdentityDbContext<AppUser, AppRole, int>
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
        modelBuilder.ApplyConfiguration(new AddressConfiguration());
        modelBuilder.ApplyConfiguration(new AppUserConfiguration());
        modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerTypeConfiguration());
        modelBuilder.ApplyConfiguration(new DistrictConfiguration());

        // seeds
        modelBuilder.ApplyConfiguration(new GroupSeed());
        modelBuilder.ApplyConfiguration(new StockSeed());
        modelBuilder.ApplyConfiguration(new CustomerTypeSeed());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Group> Groups { get; set; }
    public DbSet<Stock> Stocks { get; set; }
    public DbSet<Address>? Address { get; set; }
    public DbSet<City>? Cities { get; set; }
    public DbSet<District>? Districts { get; set; }
    public DbSet<CustomerType>? CustomerType { get; set; }
}
