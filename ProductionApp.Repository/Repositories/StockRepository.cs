using Microsoft.EntityFrameworkCore;
using ProductionApp.Entities.Models;
using ProductionApp.Repository.Abstract;
using ProductionApp.Repository.Context;

namespace ProductionApp.Repository.Repositories;

public class StockRepository : BaseRepository<Stock>, IStockRepository
{
    public StockRepository(DatabaseContext context)
        : base(context)
    {
    }

    public async Task<List<Stock>> GetAllWithGroupAsync()
    {
        var result = _context.Stocks
            .Include(x => x.Group);

        return await result
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Stock?> GetOneWithGroupAsync(int stockId)
    {
        var result = _context.Stocks
            .Include(x => x.Group)
            .Where(x => x.Id == stockId);

        return await result
            .AsNoTracking()
            .FirstOrDefaultAsync();
    }
}
