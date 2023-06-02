namespace ProductionApp.Service.Manager;

public class StockManager : IStockService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IStockRepository _stockRepository;

    public StockManager(IMapper mapper, IUnitOfWork unitOfWork, IStockRepository stockRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _stockRepository = stockRepository;
    }

    public async Task<IResponse<StockAddDto>> AddAsync(StockAddDto dto)
    {
        var stock = _mapper.Map<Stock>(dto);
        stock.CreatedDate = DateTime.Now;
        _ = await _stockRepository.CreateAsync(stock);
        var result = await _unitOfWork.SaveChangesAsync();
        if (result > 0)
            return new Response<StockAddDto>(ResponseType.Success, dto);
        return new Response<StockAddDto>(ResponseType.SaveError, "Kayıt sırasın hata oluştu");
    }

    public async Task<IResponse<List<StockListDto>>> GetAllAsync()
    {
        var stocks = await _stockRepository.GetAllWithGroupAsync();
        var dto = _mapper.Map<List<StockListDto>>(stocks);
        return new Response<List<StockListDto>>(ResponseType.Success, dto);
    }

    public async Task<IResponse<StockUpdateDto>> GetByIdAsync(int stockId)
    {
        var stock = await _stockRepository.GetOneWithGroupAsync(stockId);
        if (stock is null)
            return new Response<StockUpdateDto>(ResponseType.NotFound, "Stok bulunamadı");
        var dto = _mapper.Map<StockUpdateDto>(stock);
        return new Response<StockUpdateDto>(ResponseType.Success, dto);
    }

    public async Task<IResponse<StockUpdateDto>> UpdateAsync(StockUpdateDto dto)
    {
        var updatedData = await _stockRepository.GetByIdAsync(dto.Id);
        if (updatedData is not null)
        {
            var stockData = _mapper.Map<Stock>(dto);
            stockData.ModifiedDate = DateTime.Now;
            stockData.CreatedDate = updatedData.CreatedDate;
            _stockRepository.Update(stockData, updatedData);
            var result = await _unitOfWork.SaveChangesAsync();
            if (result > 0)
                return new Response<StockUpdateDto>(ResponseType.Success);
            return new Response<StockUpdateDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
        }
        return new Response<StockUpdateDto>(ResponseType.NotFound, "Grup bulunamadı.");
    }
}
