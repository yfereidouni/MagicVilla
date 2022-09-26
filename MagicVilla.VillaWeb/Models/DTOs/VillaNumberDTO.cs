using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaWeb.Models.DTOs;

public class VillaNumberDTO
{
    [Required]
    public int VillaNo { get; set; }
    public string SpecialDetails { get; set; }
}