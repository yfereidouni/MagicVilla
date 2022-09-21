using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository;

public class VillaRepository : IVillaRepository
{
    private readonly ApplicationDbContext _dbContext;

    public VillaRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Create(Villa entity)
    {
        await _dbContext.AddAsync(entity);
        await Save();
    }

    public Task<List<Villa>> Get(Expression<Func<Villa>> filter = null, bool tracked = true)
    {
        throw new NotImplementedException();
    }

    public Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null)
    {
        throw new NotImplementedException();
    }

    public async Task Remove(Villa entity)
    {
        _dbContext.Remove(entity);
        await Save();
    }

    public async Task Save()
    {
        await _dbContext.SaveChangesAsync();
    }
}
