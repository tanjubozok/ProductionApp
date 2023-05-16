using AutoMapper;
using ProductionApp.Common.Abstract;
using ProductionApp.Common.ComplexTypes;
using ProductionApp.Common.ResponseObjects;
using ProductionApp.DTOs.StockDtos;
using ProductionApp.Entities.Models;
using ProductionApp.Repository.Abstract;
using ProductionApp.Service.Abstract;

namespace ProductionApp.Service.Manager;

public class StockManager : IStockService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public StockManager(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IResponse<StockAddDto>> AddAsync(StockAddDto dto)
    {
        var stock = _mapper.Map<Stock>(dto);
        stock.CreatedDate = DateTime.Now;
        _ = await _unitOfWork.Stock.CreateAsync(stock);
        var result = await _unitOfWork.CommitAsync();
        if (result > 0)
            return new Response<StockAddDto>(ResponseType.Success, dto);
        return new Response<StockAddDto>(ResponseType.SaveError, "Kayıt sırasın hata oluştu");
    }

    public async Task<IResponse<List<StockListDto>>> GetAllAsync()
    {
        var stocks = await _unitOfWork.Stock.GetAllWithGroupAsync();
        var dto = _mapper.Map<List<StockListDto>>(stocks);
        return new Response<List<StockListDto>>(ResponseType.Success, dto);
    }

    public async Task<IResponse<StockUpdateDto>> GetByIdAsync(int stockId)
    {
        var stock = await _unitOfWork.Stock.GetOneWithGroupAsync(stockId);
        if (stock is null)
            return new Response<StockUpdateDto>(ResponseType.NotFound, "Stok bulunamadı");
        var dto = _mapper.Map<StockUpdateDto>(stock);
        return new Response<StockUpdateDto>(ResponseType.Success, dto);
    }

    public async Task<IResponse<StockUpdateDto>> UpdateAsync(StockUpdateDto dto)
    {
        var updatedData = await _unitOfWork.Stock.GetByIdAsync(dto.Id);
        if (updatedData is not null)
        {
            var stockData = _mapper.Map<Stock>(dto);
            stockData.ModifiedDate = DateTime.Now;
            stockData.CreatedDate = updatedData.CreatedDate;
            _unitOfWork.Stock.Update(stockData, updatedData);
            var result = await _unitOfWork.CommitAsync();
            if (result > 0)
                return new Response<StockUpdateDto>(ResponseType.Success);
            return new Response<StockUpdateDto>(ResponseType.SaveError, "Kayıt sırasında hata oluştu");
        }
        return new Response<StockUpdateDto>(ResponseType.NotFound, "Grup bulunamadı.");
    }
}
