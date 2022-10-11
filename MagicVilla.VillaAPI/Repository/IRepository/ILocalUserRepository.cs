using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;

namespace MagicVilla.VillaAPI.Repository.IRepository;

public interface ILocalUserRepository
{
    public bool IsUniqueUser(string username);
    Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
    Task<LocalUser> Register(RegistrationRequestDTO registrationRequestDTO);

}
