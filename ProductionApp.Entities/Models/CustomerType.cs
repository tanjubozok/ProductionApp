using ProductionApp.Entities.Abstract;

namespace ProductionApp.Entities.Models;

public class CustomerType : IBaseEntity
{
    public int Id { get; set; }
    public string? ShortName { get; set; }
    public string? LongName { get; set; }

    public AppUser? AppUser { get; set; }
}
