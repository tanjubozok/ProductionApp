using ProductionApp.Repository.Abstract;
using ProductionApp.Repository.Context;
using ProductionApp.Repository.Repositories;

namespace ProductionApp.Repository.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _context;
    private GroupRepository _groupRepository;
    private StockRepository _stockRepository;

    public UnitOfWork(DatabaseContext context)
        => _context = context;

    public IGroupRepository Group
        => _groupRepository ?? new GroupRepository(_context);

    public IStockRepository Stock
        => _stockRepository ?? new StockRepository(_context);

    public int Commit()
        => _context.SaveChanges();

    public Task<int> CommitAsync()
        => _context.SaveChangesAsync();
}
