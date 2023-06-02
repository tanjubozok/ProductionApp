namespace ProductionApp.Service.DependencyResolvers;

public static class DependencyExtension
{
    public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        #region Database Connection

        services.AddDbContext<DatabaseContext>(opt =>
        {
            opt.UseSqlServer(configuration.GetConnectionString("LocalSqlServer"));
        });

        #endregion

        #region Identity Configurations

        services.AddIdentity<AppUser, AppRole>(opt =>
        {
            // Password settings
            opt.Password.RequireDigit = true;
            opt.Password.RequiredLength = 4;
            opt.Password.RequireNonAlphanumeric = false;
            opt.Password.RequireUppercase = false;
            opt.Password.RequireLowercase = false;
            opt.Password.RequiredUniqueChars = 0;
        })
                   .AddEntityFrameworkStores<DatabaseContext>();

        services.ConfigureApplicationCookie(opt =>
        {
            opt.Cookie.Name = "JobTrackingApp";
            opt.Cookie.SameSite = SameSiteMode.Strict;
            opt.Cookie.HttpOnly = true;
            opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            opt.ExpireTimeSpan = TimeSpan.FromDays(20);

            opt.LoginPath = "/Member/Account/Login";
            opt.LogoutPath = "/Member/Account/Logout";
            opt.AccessDeniedPath = "/Member/Account/AccessDenied";
        });


        #endregion

        #region Validation

        services.AddTransient<IValidator<GroupAddDto>, GroupAddDtoValidator>();
        services.AddTransient<IValidator<GroupUpdateDto>, GroupUpdateValidator>();

        services.AddTransient<IValidator<StockAddDto>, StockAddDtoValidator>();
        services.AddTransient<IValidator<StockUpdateDto>, StockUpdateDtoValidator>();

        #endregion

        #region DI
        // Repositories
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<IStockRepository, StockRepository>();

        // Services
        services.AddScoped<IGroupService, GroupManager>();
        services.AddScoped<IStockService, StockManager>();

        #endregion

        #region AutoMapper

        var profiles = ProfileHelper.GetProfiles();
        var config = new MapperConfiguration(opt =>
        {
            opt.AddProfiles(profiles);
        });
        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);

        #endregion
    }
}
