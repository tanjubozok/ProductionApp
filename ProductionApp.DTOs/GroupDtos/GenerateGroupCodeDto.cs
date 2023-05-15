using ProductionApp.DTOs.Abstract;

namespace ProductionApp.DTOs.GroupDtos;

public class GenerateGroupCodeDto : IBaseDto
{
    public string? GenerateCode { get; set; }
}
