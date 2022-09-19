using MagicVilla.VillaAPI.Data;
using MagicVilla.VillaAPI.Models;
using MagicVilla.VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace MagicVilla.VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ILogger<VillaAPIController> _logger;

        public VillaAPIController(ILogger<VillaAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetVillas()
        {
            _logger.LogInformation("iLog: Getting All villas");
            return Ok(VillaStore.VillaList);
        }

        [HttpGet("id:int", Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        public IActionResult GetVilla(int id)
        {
            if (id == 0)
            {
                _logger.LogInformation($"iLog: Get Villa Error with Id {id}");
                return BadRequest();
            }

            var villa = VillaStore.VillaList.FirstOrDefault(c => c.Id == id);

            if (villa == null)
                return NotFound();

            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateVilla([FromBody] VillaDTO villaDTO)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest(ModelState);

            if (VillaStore.VillaList.FirstOrDefault(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("", "Villa already exists!");
                return BadRequest(ModelState);
            }

            if (villaDTO is null)
                return BadRequest();

            if (villaDTO.Id > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);

            villaDTO.Id = VillaStore.VillaList.OrderByDescending(c => c.Id).FirstOrDefault().Id + 1;

            VillaStore.VillaList.Add(villaDTO);

            //return Ok(villaDTO);
            return CreatedAtRoute("GetVilla", new { id = villaDTO.Id }, villaDTO);
        }

        [HttpDelete("id:int", Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
                return BadRequest();

            var villa = VillaStore.VillaList.FirstOrDefault(c => c.Id == id);

            if (villa == null)
                return NotFound();

            VillaStore.VillaList.Remove(villa);
            return NoContent();
        }

        [HttpPut("id:int", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDTO villaDTO)
        {
            if (villaDTO == null || id != villaDTO.Id)
                return BadRequest();

            var villa = VillaStore.VillaList.FirstOrDefault(c => c.Id == id);

            if (villa is null)
                return NotFound();

            villa.Name = villaDTO.Name;
            villa.Occupancy = villaDTO.Occupancy;
            villa.Sqft = villaDTO.Sqft;
            villa.CreatedDate = villaDTO.CreatedDate;

            return NoContent();
        }

        [HttpPatch("id:int", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO)
        {
            if (patchDTO == null || id ==0)
                return BadRequest();

            var villa = VillaStore.VillaList.FirstOrDefault(c => c.Id == id);

            if (villa is null)
                return NotFound();

            //Syntax for JsonPatchDocument
            patchDTO.ApplyTo(villa,ModelState);
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return NoContent();
        }

    }
}
