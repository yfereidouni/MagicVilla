using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaAPI.Models.DTOs;

public class VillaNumberDTO
{
    [Required]
    public int VillaNo { get; set; }
    public string SpecialDetails { get; set; }
    public VillaDTO Villa { get; set; }
}