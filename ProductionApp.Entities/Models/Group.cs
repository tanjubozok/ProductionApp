namespace ProductionApp.Entities.Models;

public class Group : IBaseEntity
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public List<Stock>? Stocks { get; set; }
}
