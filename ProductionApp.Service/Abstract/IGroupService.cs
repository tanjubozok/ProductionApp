using ProductionApp.Common.Abstract;
using ProductionApp.DTOs.GroupDtos;

namespace ProductionApp.Service.Abstract;

public interface IGroupService
{
    Task<IResponse<List<GroupListDto>>> GetAllAsync();
    Task<IResponse<GroupUpdateDto>> GetByIdAsync(int groupId);
    Task<IResponse<GroupAddDto>> AddAsync(GroupAddDto dto);
    Task<IResponse<GroupUpdateDto>> UpdateAsync(GroupUpdateDto dto);
    Task<string> GenerateGroupCodeAsync();
}
