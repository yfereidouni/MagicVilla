using MagicVilla.VillaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla.VillaAPI.Repository.IRepository;

public interface IVillaRepository : IRepository<Villa>
{
    Task<Villa> UpdateAsync(Villa entity);
}
