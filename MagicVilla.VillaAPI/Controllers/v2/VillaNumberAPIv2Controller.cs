using AutoMapper;
using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Logging;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Reflection.Metadata;

namespace MagicVilla.VillaAPI.Controllers.v2;

//[Route("api/[controller]")]
//[Route("api/VillaNumberAPI")]
[Route("api/v{version:apiVersion}/VillaNumberAPI")]
[ApiController]
[ApiVersion("2.0")]
public class VillaNumberAPIv2Controller : ControllerBase
{
    protected APIResponse _response;
    private readonly IVillaRepository _villaRepository;
    private readonly IVillaNumberRepository _villaNumberRepository;
    private readonly IMapper _mapper;
    private readonly ILogging _logger;
    private readonly ILogger<VillaNumberAPIv2Controller> _logger1;

    public VillaNumberAPIv2Controller(
        IVillaRepository villaRepository,
        IVillaNumberRepository villaNumberRepository,
        IMapper mapper,
        ILogging logger,
        ILogger<VillaNumberAPIv2Controller> logger1)
    {
        _villaRepository = villaRepository;
        _villaNumberRepository = villaNumberRepository;
        _mapper = mapper;
        _logger = logger;
        _logger1 = logger1;

        _response = new();
    }

    //[MapToApiVersion("2.0")]
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

}
