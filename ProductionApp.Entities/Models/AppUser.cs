using Microsoft.AspNetCore.Identity;
using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class AppUser : IdentityUser<int>, IBaseEntity
{
    public string? Name { get; set; }
    public string? Surname { get; set; }

    public int? DistrictId { get; set; }
    public District? District { get; set; }

    public int? CityId { get; set; }
    public City? City { get; set; }

    public int? CustomerTypeId { get; set; }
    public CustomerType? CustomerType { get; set; }
}
