using MagicVilla.VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository.IRepository;

public interface IVillaRepository
{
    //GetAll : this method can get any LINQ Expression as a filter
    Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null);
    Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked = true);
    Task CreateAsync(Villa entity);
    Task UpdateAsync(Villa entity);
    Task RemoveAsync(Villa entity);
    Task SaveAsync();
}
