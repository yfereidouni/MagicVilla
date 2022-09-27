using MagicVilla.VillaWeb.Models;

namespace MagicVilla.VillaWeb.Services.IServices;

public interface IBaseService
{
    APIResponse responseModel { get; set; }
    Task<T> SendAsync<T>(APIRequest apiRequest);
}
