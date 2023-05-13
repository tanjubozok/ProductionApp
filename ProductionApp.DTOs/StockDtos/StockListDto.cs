using ProductionApp.DTOs.Abstract;

namespace ProductionApp.DTOs.StockDtos;

public class StockListDto : IBaseDto
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public decimal VAT { get; set; }
    public int GroupId { get; set; }
}
