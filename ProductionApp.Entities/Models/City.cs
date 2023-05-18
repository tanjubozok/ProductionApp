using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class City : IBaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public AppUser? AppUser { get; set; }
}
