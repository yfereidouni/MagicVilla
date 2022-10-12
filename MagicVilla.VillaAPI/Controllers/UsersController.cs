using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagicVilla.VillaAPI.Controllers;

//[Route("api/[controller]")]
[Route("api/UsersAuth")]
[ApiController]
public class UsersController : Controller
{
    private readonly ILocalUserRepository _UserRepo;
    protected APIResponse _response;

    public UsersController(ILocalUserRepository userRepo)
    {
        _UserRepo = userRepo;
        _response = new APIResponse();
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
    {
        var LoginResponse = await _UserRepo.Login(model);
        if (LoginResponse.User == null || string.IsNullOrEmpty(LoginResponse.Token))
        {
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Username or password is incorrect!");
            return BadRequest(_response);
        }
        _response.StatusCode = HttpStatusCode.OK;
        _response.IsSuccess = true;
        _response.Result = LoginResponse;
        return Ok(_response);
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO model)
    {
        bool isUserNameUnique = _UserRepo.IsUniqueUser(model.UserName);
        if (!isUserNameUnique)
        {
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Username already exists!");
            return BadRequest(_response);
        }

        var user = await _UserRepo.Register(model);
        if (user == null)
        {
            _response.StatusCode = HttpStatusCode.BadRequest;
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Username or password is incorrect!");
            return BadRequest(_response);
        }
        _response.StatusCode = HttpStatusCode.OK;
        _response.IsSuccess = true;
        return Ok(_response);

    }
}
