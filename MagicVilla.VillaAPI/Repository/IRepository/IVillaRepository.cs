using MagicVilla.VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository.IRepository;

public interface IVillaRepository
{
    //GetAll : this method can get any LINQ Expression as a filter
    Task<List<Villa>> GetAll(Expression<Func<Villa,bool>> filter = null);
    Task<Villa> Get(Expression<Func<Villa,bool>> filter = null, bool tracked = true);
    Task Create(Villa entity);
    Task Remove(Villa entity);
    Task Save();
}
