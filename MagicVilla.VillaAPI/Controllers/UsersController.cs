using MagicVilla.VillaAPI.Models.DTOs;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.VillaAPI.Controllers;

//[Route("api/[controller]")]
[Route("api/UsersAuth")]
[ApiController]
public class UsersController : Controller
{
    private readonly ILocalUserRepository _UserRepo;

    public UsersController(ILocalUserRepository userRepo)
    {
        _UserRepo = userRepo;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDTO model)
    {
        var LoginResponse = await _UserRepo.Login(model);
        if (LoginResponse.User == null || string.IsNullOrEmpty(LoginResponse.Token))
        {
            return BadRequest(new { message = "Username or password is incorrect" });
        }
        return View();
    }

    [HttpPost("Register")]
    public async Task<IActionResult> Register([FromBody] RegistrationRequestDTO model)
    {

        return View();
    }
}
