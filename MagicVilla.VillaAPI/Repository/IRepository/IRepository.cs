using MagicVilla.VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository.IRepository;

public interface IRepository<T> where T : class
{
    //GetAll : this method can get any LINQ Expression as a filter
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
    Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true);
    Task CreateAsync(T entity);
    Task RemoveAsync(T entity);
    Task SaveAsync();
}
