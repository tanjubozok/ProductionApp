using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductionApp.DTOs.GroupDtos;
using ProductionApp.Repository.Abstract;
using ProductionApp.Repository.Context;
using ProductionApp.Repository.Repositories;
using ProductionApp.Repository.UnitOfWorks;
using ProductionApp.Service.Abstract;
using ProductionApp.Service.Manager;
using ProductionApp.Service.Mappings.Helpers;
using ProductionApp.Service.ValidationRules;

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

        #region Validation

        services.AddTransient<IValidator<GroupAddDto>, GroupAddDtoValidator>();
        services.AddTransient<IValidator<GroupUpdateDto>, GroupUpdateValidator>();

        #endregion

        #region DI
        // Repositories
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IGroupRepository, GroupRepository>();

        // Services
        services.AddScoped<IGroupService, GroupManager>();

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
