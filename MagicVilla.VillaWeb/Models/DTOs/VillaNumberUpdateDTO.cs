using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaWeb.Models.DTOs;

public sealed class VillaNumberUpdateDTO
{
    [Required]
    public int VillaNo { get; set; }
    [Required]
    public int VillaId { get; set; }
    public string SpecialDetails { get; set; }
}