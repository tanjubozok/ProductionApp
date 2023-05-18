using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class District : IBaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int CityId { get; set; }
    public City? City { get; set; }

    public int? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}
