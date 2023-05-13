namespace ProductionApp.Repository.Abstract;

public interface IUnitOfWork
{
    Task<int> CommitAsync();
    int Commit();
}
