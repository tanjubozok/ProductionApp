namespace ProductionApp.Service.Abstract;

public interface IStockService
{
    Task<IResponse<List<StockListDto>>> GetAllAsync();
    Task<IResponse<StockUpdateDto>> GetByIdAsync(int stockId);
    Task<IResponse<StockAddDto>> AddAsync(StockAddDto dto);
    Task<IResponse<StockUpdateDto>> UpdateAsync(StockUpdateDto dto);
}
