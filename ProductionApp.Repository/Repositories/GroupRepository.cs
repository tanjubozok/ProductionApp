namespace ProductionApp.Repository.Repositories;

public class GroupRepository : BaseRepository<Group>, IGroupRepository
{
    public GroupRepository(DatabaseContext context)
        : base(context)
    {
    }

    public async Task<string> GenerateGroupCodeAsync()
    {
        var maxIdRecord = await _context.Groups
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefaultAsync();

        string groupCode = maxIdRecord!.Code!;
        int counter = 1;
        int number = int.Parse(groupCode.Substring(2));
        number += counter;
        return groupCode.Substring(0, 2) + number.ToString("D3");
    }
}
