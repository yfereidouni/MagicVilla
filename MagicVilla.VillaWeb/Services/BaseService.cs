using MagicVilla.VillaWeb.Models;
using MagicVilla.VillaWeb.Services.IServices;
using Newtonsoft.Json;
using System.Text;

namespace MagicVilla.VillaWeb.Services;

public abstract class BaseService : IBaseService
{
    private readonly IHttpClientFactory httpClient;

    public BaseService(IHttpClientFactory httpClient)
    {
        this.responseModel = new();
        this.httpClient = httpClient;
    }
    public APIResponse responseModel { get; set; }

    public async Task<T> SendAsync<T>(APIRequest apiRequest)
    {
        try
        {
            var client = httpClient.CreateClient("VillaAPI");
            HttpRequestMessage message = new HttpRequestMessage();
            message.Headers.Add("Accept", "application/json");
            message.RequestUri = new Uri(apiRequest.Url);
            if (apiRequest.Data != null)
            {
                message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                    Encoding.UTF8, "application/json");
            }
            switch (apiRequest.ApiType)
            {
                case Utility.SD.ApiType.GET:
                    message.Method = HttpMethod.Get;
                    break;
                case Utility.SD.ApiType.POST:
                    message.Method = HttpMethod.Post;
                    break;
                case Utility.SD.ApiType.PUT:
                    message.Method = HttpMethod.Put;
                    break;
                case Utility.SD.ApiType.DELETE:
                    message.Method = HttpMethod.Delete;
                    break;
                case Utility.SD.ApiType.PATCH:
                    message.Method = HttpMethod.Patch;
                    break;
            }

            HttpResponseMessage apiResponse = null;
            
            apiResponse = await client.SendAsync(message);

            var apiContent = await apiResponse.Content.ReadAsStringAsync();

            try
            {
                APIResponse ApiResponse = JsonConvert.DeserializeObject<APIResponse>(apiContent);
                if (apiResponse.StatusCode==System.Net.HttpStatusCode.BadRequest || 
                    apiResponse.StatusCode==System.Net.HttpStatusCode.NotFound)
                {
                    ApiResponse.StatusCode = System.Net.HttpStatusCode.BadRequest;
                    ApiResponse.IsSuccess = false;
                    var res = JsonConvert.SerializeObject(ApiResponse);
                    var returnObj = JsonConvert.DeserializeObject<T>(res);
                    return returnObj;

                }
            }
            catch (Exception ex)
            {
                var exceptionResponse = JsonConvert.DeserializeObject<T>(apiContent);
                return exceptionResponse;
            }

            var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);
            return APIResponse;

        }
        catch (Exception ex)
        {
            var dto = new APIResponse
            {
                ErrorMessages = new List<string> { Convert.ToString(ex.Message) },
                IsSuccess = false,
            };
            var res = JsonConvert.SerializeObject(dto);
            var APIResponse = JsonConvert.DeserializeObject<T>(res);
            return APIResponse;
        }
    }
}
