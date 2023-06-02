namespace ProductionApp.DTOs.GroupDtos;

public class GroupAddDto : IBaseDto
{
    public string? Code { get; set; }
    public string? Name { get; set; }
    public string? Color { get; set; }
    public DateTime CreatedDate { get; set; }
}
