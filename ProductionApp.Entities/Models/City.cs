namespace ProductionApp.Entities.Models;

public class City : IBaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}
