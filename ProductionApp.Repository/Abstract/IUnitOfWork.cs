namespace ProductionApp.Repository.Abstract;

public interface IUnitOfWork
{
    IGroupRepository Group { get; }
    IStockRepository Stock { get; }

    Task<int> CommitAsync();
    int Commit();
}
