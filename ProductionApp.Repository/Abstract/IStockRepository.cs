using ProductionApp.Entities.Models;

namespace ProductionApp.Repository.Abstract;

public interface IStockRepository : IBaseRepository<Stock>
{
    Task<List<Stock>> GetAllWithGroupAsync();
    Task<Stock?> GetOneWithGroupAsync(int stockId);
}
