using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository;

public class VillaRepository : IVillaRepository
{
    private readonly ApplicationDbContext _dbContext;

    public VillaRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task CreateAsync(Villa entity)
    {
        await _dbContext.AddAsync(entity);
        await SaveAsync();
    }

    public async Task<Villa> GetAsync(Expression<Func<Villa, bool>> filter = null, bool tracked = true)
    {
        IQueryable<Villa> query = _dbContext.Villas;
        
        if (!tracked)
            query = query.AsNoTracking();
        
        if (filter is not null)
            query = query.Where(filter);
        
        //Query execute here! This is "Deferred execution"
        return await query.FirstOrDefaultAsync();
    }

    public async Task<List<Villa>> GetAllAsync(Expression<Func<Villa, bool>> filter = null)
    {
        IQueryable<Villa> query = _dbContext.Villas;
        
        if (filter is not null)
            query = query.Where(filter);
        
        //Query execute here! This is "Deferred execution"
        return await query.ToListAsync();
    }

    public async Task RemoveAsync(Villa entity)
    {
        _dbContext.Remove(entity);
        await SaveAsync();
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Villa entity)
    {
        _dbContext.Villas.Update(entity);
        await SaveAsync();
    }
}
