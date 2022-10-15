﻿using MagicVilla.Utility;
using MagicVilla.VillaWeb.Models.DTOs;
using MagicVilla.VillaWeb.Services.IServices;

namespace MagicVilla.VillaWeb.Services;

public sealed class VillaNumberService : BaseService, IVillaNumberService
{
    private readonly IHttpClientFactory _clientFactory;
    private string villaUrl;

    public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
    {
        _clientFactory = clientFactory;
        villaUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
    }

    public Task<T> CreateAsync<T>(VillaNumberCreateDTO dto, string token)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.POST,
            Data = dto,
            Url = villaUrl + "/api/v1/VillaNumberAPI",
            Token = token
        });
    }

    public Task<T> DeleteAsync<T>(int id, string token)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.DELETE,
            Url = villaUrl + "/api/v1/VillaNumberAPI/" + id,
            Token = token
        });
    }

    public Task<T> GetAllAsync<T>(string token)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = villaUrl + "/api/v1/VillaNumberAPI/",
            Token = token
        });
    }

    public Task<T> GetAsync<T>(int id, string token)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.GET,
            Url = villaUrl + "/api/v1/VillaNumberAPI/" + id,
            Token = token
        });
    }

    public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO dto, string token)
    {
        return SendAsync<T>(new Models.APIRequest()
        {
            ApiType = SD.ApiType.PUT,
            Data = dto,
            Url = villaUrl + "/api/v1/VillaNumberAPI/" + dto.VillaNo,
            Token = token
        });
    }
}
