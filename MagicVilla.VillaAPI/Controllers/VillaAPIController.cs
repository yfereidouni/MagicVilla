using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return new List<VillaDTO>()
            {
                new VillaDTO {Id=1, Name = "Pool View" ,CreatedDate=DateTime.Now },
                new VillaDTO {Id=2, Name = "Beach View",CreatedDate=DateTime.Now }
            };
        }

    }
}
