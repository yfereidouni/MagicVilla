using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Logging;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace MagicVilla.VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILogging _logger;
        private readonly ILogger<VillaAPIController> _logger1;

        public VillaAPIController(ApplicationDbContext dbContext, ILogging logger, ILogger<VillaAPIController> logger1)
        {
            _dbContext = dbContext;
            _logger = logger;
            _logger1 = logger1;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetVillas()
        {
            _logger1.LogInformation($"(Serilog) Getting All villas");
            _logger.Log("(iLog) Getting All villas", "info");

            return Ok(await _dbContext.Villas.ToListAsync());
        }

        [HttpGet("id:int", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        public async Task<IActionResult> GetVilla(int id)
        {
            if (id == 0)
            {
                _logger1.LogInformation($"(Serilog) Get Villa Error with Id {id}");
                _logger.Log($"(iLog) Get Villa Error with Id {id}", "error");

                return BadRequest();
            }

            var villa = await _dbContext.Villas.FirstOrDefaultAsync(c => c.Id == id);

            if (villa == null)
                return NotFound();

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateVilla([FromBody] VillaCreateDTO villaDTO)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            if (await _dbContext.Villas.FirstOrDefaultAsync(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("", "Villa already exists!");
                return BadRequest(ModelState);
            }

            if (villaDTO is null)
                return BadRequest();

            //if (villaDTO.Id > 0)
            //    return StatusCode(StatusCodes.Status500InternalServerError);

            Villa model = new()
            {
                Name = villaDTO.Name,
                Details = villaDTO.Details,
                Rate = villaDTO.Rate,
                ImageUrl = villaDTO.ImageUrl,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
            };
            await _dbContext.Villas.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            //return Ok(villaDTO);
            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }

        [HttpDelete("id:int", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id == 0)
                return BadRequest();

            var villa = await _dbContext.Villas.FirstOrDefaultAsync(c => c.Id == id);

            if (villa == null)
                return NotFound();

            _dbContext.Villas.Remove(villa);
            return NoContent();
        }

        [HttpPut("id:int", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDTO)
        {
            if (villaDTO == null || id != villaDTO.Id)
                return BadRequest();

            Villa model = new()
            {
                Id = villaDTO.Id,
                Name = villaDTO.Name,
                Details = villaDTO.Details,
                Rate = villaDTO.Rate,
                ImageUrl = villaDTO.ImageUrl,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
            };
            _dbContext.Villas.Update(model);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPatch("id:int", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
                return BadRequest();

            var villa = await _dbContext.Villas.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);

            if (villa is null)
                return NotFound();


            VillaUpdateDTO villaDTO = new()
            {
                Id = villa.Id,
                Name = villa.Name,
                Details = villa.Details,
                Rate = villa.Rate,
                ImageUrl = villa.ImageUrl,
                Occupancy = villa.Occupancy,
                Sqft = villa.Sqft,
                Amenity = villa.Amenity,
            };

            //Syntax for JsonPatchDocument
            patchDTO.ApplyTo(villaDTO, ModelState);

            Villa model = new()
            {
                Id = villaDTO.Id,
                Name = villaDTO.Name,
                Details = villaDTO.Details,
                Rate = villaDTO.Rate,
                ImageUrl = villaDTO.ImageUrl,
                Occupancy = villaDTO.Occupancy,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
            };

            _dbContext.Villas.Update(model);
            await _dbContext.SaveChangesAsync();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return NoContent();
        }

    }
}
