﻿namespace ProductionApp.DTOs.StockDtos;

public class StockUpdateDto : IBaseDto
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public int VAT { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public int GroupId { get; set; }
}
