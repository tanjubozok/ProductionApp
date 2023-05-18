using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class Address : IBaseEntity
{
    public int Id { get; set; }
    public string? Description { get; set; }

    public List<AppUser>? AppUsers { get; set; }
}
