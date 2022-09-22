using AutoMapper;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using System.Runtime;

namespace MagicVilla.VillaAPI;

public class MappingConfig:Profile
{
	public MappingConfig()
	{
        CreateMap<Villa, VillaDTO>().ReverseMap();
        CreateMap<Villa, VillaCreateDTO>().ReverseMap();
        CreateMap<Villa, VillaUpdateDTO>().ReverseMap(); 
        
        CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
        CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
        CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
    }
}
