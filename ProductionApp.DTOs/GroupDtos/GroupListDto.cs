using ProductionApp.DTOs.Abstract;

namespace ProductionApp.DTOs.GroupDtos;

public class GroupListDto : IBaseDto
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
}
