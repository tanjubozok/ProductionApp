using ProductionApp.Entities.Models;
using ProductionApp.Repository.Abstract;
using ProductionApp.Repository.Context;

namespace ProductionApp.Repository.Repositories;

public class StockRepository : BaseRepository<Stock>, IStockRepository
{
    public StockRepository(DatabaseContext context) : base(context)
    {
    }
}
