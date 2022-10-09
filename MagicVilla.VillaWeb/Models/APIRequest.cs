using System.Net;
using static MagicVilla.Utility.SD;

namespace MagicVilla.VillaWeb.Models;

public sealed class APIRequest
{
    public ApiType ApiType { get; set; } = ApiType.GET;
    public string Url { get; set; }
    public object Data { get; set; }
}
