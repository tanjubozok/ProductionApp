using ProductionApp.Entities.Models;
using ProductionApp.Repository.Abstract;
using ProductionApp.Repository.Context;

namespace ProductionApp.Repository.Repositories;

public class GroupRepository : BaseRepository<Group>, IGroupRepository
{
    public GroupRepository(DatabaseContext context) : base(context)
    {
    }
}
