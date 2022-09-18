using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace MagicVilla.VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.VillaList;
        }

        [HttpGet("id:int")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.VillaList.FirstOrDefault(c => c.Id == id);
        }
    }
}
