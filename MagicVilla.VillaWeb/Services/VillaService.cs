using MagicVilla.Utility;
using MagicVilla.VillaWeb.Models.DTOs;
using MagicVilla.VillaWeb.Services.IServices;

namespace MagicVilla.VillaWeb.Services;

public sealed class VillaService : BaseService, IVillaService
{
    private readonly IHttpClientFactory _clientFactory;
    private string villaUrl;

    public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
    {
        _clientFactory = clientFactory;
        villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
    }

    public Task<T> CreateAsync<T>(VillaCreateDTO dto)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = dto,
            Url = villaUrl + "/api/VillaAPI"
        });
    }

    public Task<T> DeleteAsync<T>(int id)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.DELETE,
            Url = villaUrl + "/api/VillaAPI/" + id
        });
    }

    public Task<T> GetAllAsync<T>()
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = villaUrl + "/api/VillaAPI/"
        });
    }

    public Task<T> GetAsync<T>(int id)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = villaUrl + "/api/VillaAPI/" + id
        });
    }

    public Task<T> UpdateAsync<T>(VillaUpdateDTO dto)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.PUT,
            Data = dto,
            Url = villaUrl + "/api/VillaAPI/" + dto.Id
        });
    }
}
