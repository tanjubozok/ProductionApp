using ProductionApp.DTOs.Abstract;

namespace ProductionApp.DTOs.GroupDtos;

public class GroupUpdateDto : IBaseDto
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public DateTime ModifiedData { get; set; }
}
