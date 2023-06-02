namespace ProductionApp.Repository.Abstract;

public interface IGroupRepository : IBaseRepository<Group>
{
    public Task<string> GenerateGroupCodeAsync();
}
