namespace ProductionApp.Entities.Models;

public class Stock : IBaseEntity
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int VAT { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public int GroupId { get; set; }
    public Group? Group { get; set; }
}
