namespace ProductionApp.Service.Mappings.AutoMapper;

public class StockProfile : Profile
{
    public StockProfile()
    {
        CreateMap<Stock, StockListDto>().ReverseMap();
        CreateMap<Stock, StockAddDto>().ReverseMap();
        CreateMap<Stock, StockUpdateDto>().ReverseMap();
    }
}
