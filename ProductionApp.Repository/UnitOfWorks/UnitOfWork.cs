﻿namespace ProductionApp.Repository.UnitOfWorks;

public class UnitOfWork : IUnitOfWork
{
    private readonly DatabaseContext _context;

    public UnitOfWork(DatabaseContext context)
        => _context = context;

    public int SaveChanges()
        => _context.SaveChanges();

    public Task<int> SaveChangesAsync()
        => _context.SaveChangesAsync();
}
