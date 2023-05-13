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
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public GroupManager(IGroupRepository groupRepository, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IResponse<GroupAddDto>> AddAsync(GroupAddDto dto)
    {
        var group = _mapper.Map<Group>(dto);
        group.CreatedDate = dto.CreatedDate;
        _ = await _groupRepository.CreateAsync(group);
        var result = await _unitOfWork.CommitAsync();
        if (result > 0)
            return new Response<GroupAddDto>(ResponseType.Success, dto);
        return new Response<GroupAddDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
    }

    public async Task<IResponse<List<GroupListDto>>> GetAllAsync()
    {
        var groups = await _groupRepository.GetAllAsync();
        var dto = _mapper.Map<List<GroupListDto>>(groups);
        return new Response<List<GroupListDto>>(ResponseType.Success, dto);
    }

    public async Task<IResponse<GroupListDto>> GetOneAsync()
    {
        var group = await _groupRepository.GetOneAsync();
        var dto = _mapper.Map<GroupListDto>(group);
        return new Response<GroupListDto>(ResponseType.Success, dto);
    }

    public async Task<IResponse> RemoveAsync(int id)
    {
        var group = await _groupRepository.GetByIdAsync(id);
        if (group is not null)
        {
            _groupRepository.Delete(group);
            var result = await _unitOfWork.CommitAsync();
            if (result > 0)
                return new Response<GroupAddDto>(ResponseType.Success, $"{group.Name} silindi.");
            return new Response<GroupAddDto>(ResponseType.SaveError, "Silme sırasında hata oluştu");
        }
        return new Response<GroupAddDto>(ResponseType.NotFound, "Grup bulunamadı.");
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
            var result = await _unitOfWork.CommitAsync();
            if (result > 0)
                return new Response<GroupUpdateDto>(ResponseType.Success);
            return new Response<GroupUpdateDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
        }
        return new Response<GroupUpdateDto>(ResponseType.NotFound, "Grup bulunamadı.");
    }
}
