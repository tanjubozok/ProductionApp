using AutoMapper;
using ProductionApp.DTOs.GroupDtos;
using ProductionApp.Entities.Models;

namespace ProductionApp.Service.Mappings.AutoMapper;

public class GroupProfile : Profile
{
    public GroupProfile()
    {
        this.CreateMap<Group, GroupListDto>().ReverseMap();
        this.CreateMap<Group, GroupAddDto>().ReverseMap();
        this.CreateMap<Group, GroupUpdateDto>().ReverseMap();
    }
}
