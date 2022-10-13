using MagicVilla.VillaWeb.Models.DTOs;
using System.Threading.Tasks;

namespace MagicVilla.VillaWeb.Services.IServices;

public interface IAuthService
{
    Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
    Task<T> RegisterAsync<T>(RegistrationRequestDTO objToCreate);

}
