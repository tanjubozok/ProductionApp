using AutoMapper;
using ProductionApp.Common.Abstract;
using ProductionApp.Common.ComplexTypes;
using ProductionApp.Common.ResponseObjects;
using ProductionApp.DTOs.GroupDtos;
using ProductionApp.Entities.Models;
using ProductionApp.Repository.Abstract;
using ProductionApp.Service.Abstract;

namespace ProductionApp.Service.Manager;

public class GroupManager : IGroupService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGroupRepository _groupRepository;

    public GroupManager(IMapper mapper, IUnitOfWork unitOfWork, IGroupRepository groupRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _groupRepository = groupRepository;
    }

    public async Task<IResponse<GroupAddDto>> AddAsync(GroupAddDto dto)
    {
        var group = _mapper.Map<Group>(dto);
        group.CreatedDate = DateTime.Now;
        _ = await _groupRepository.CreateAsync(group);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result > 0)
            return new Response<GroupAddDto>(ResponseType.Success, dto);
        return new Response<GroupAddDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
    }

    public async Task<string> GenerateGroupCodeAsync()
        => await _groupRepository.GenerateGroupCodeAsync();

    public async Task<IResponse<List<GroupListDto>>> GetAllAsync()
    {
        var groups = await _groupRepository.GetAllAsync();
        var dto = _mapper.Map<List<GroupListDto>>(groups);
        return new Response<List<GroupListDto>>(ResponseType.Success, dto);
    }

    public async Task<IResponse<GroupUpdateDto>> GetByIdAsync(int groupId)
    {
        var group = await _groupRepository.GetByIdAsync(groupId);
        if (group is null)
            return new Response<GroupUpdateDto>(ResponseType.NotFound, "Grup bulunamadı");
        var dto = _mapper.Map<GroupUpdateDto>(group);
        return new Response<GroupUpdateDto>(ResponseType.Success, dto);
    }

    public async Task<IResponse<GroupUpdateDto>> UpdateAsync(GroupUpdateDto dto)
    {
        var updatedData = await _groupRepository.GetByIdAsync(dto.Id);
        if (updatedData is not null)
        {
            var group = _mapper.Map<Group>(dto);
            group.ModifiedDate = DateTime.Now;
            group.CreatedDate = updatedData.CreatedDate;
            _groupRepository.Update(group, updatedData);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result > 0)
                return new Response<GroupUpdateDto>(ResponseType.Success);
            return new Response<GroupUpdateDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
        }
        return new Response<GroupUpdateDto>(ResponseType.NotFound, "Grup bulunamadı.");
    }
}
