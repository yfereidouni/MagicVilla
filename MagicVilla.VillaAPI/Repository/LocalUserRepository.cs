using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using MagicVilla.VillaAPI.Repository.IRepository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MagicVilla.VillaAPI.Repository;

public class LocalUserRepository : ILocalUserRepository
{
    private readonly ApplicationDbContext _dbContext;
    private string secretKey;

    public LocalUserRepository(ApplicationDbContext dbContext,IConfiguration configuration)
    {
        _dbContext = dbContext;
        secretKey = configuration.GetValue<string>("ApiSettings:Secret");
    }

    public bool IsUniqueUser(string username)
    {
        var user = _dbContext.LocalUsers.FirstOrDefault(x => x.UserName == username);
        if (user != null)
        {
            return false;
        }
        return true;
    }

    public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
    {
        var user = _dbContext.LocalUsers.FirstOrDefault(x => x.UserName.ToLower() == loginRequestDTO.UserName.ToLower() &&
        x.Password == loginRequestDTO.Password);

        if (user==null)
        {
            return new LoginResponseDTO()
            {
                Token = "",
                User = null
            };
        }

        //if user found generate JWT Token

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(secretKey);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name,user.Id.ToString()),
                new Claim(ClaimTypes.Role,user.Role.ToString())
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
        {
            User = user,
            Token = tokenHandler.WriteToken(token)
        };

        return loginResponseDTO;
    }

    public async Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO)
    {
        LocalUser user = new()
        {
            UserName = registrationRequestDTO.UserName,
            Password = registrationRequestDTO.Password,
            Name = registrationRequestDTO.Name,
            Role = registrationRequestDTO.Role,
        };
        await _dbContext.LocalUsers.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        user.Password = string.Empty;
        return user;
    }
}
