using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaWeb.Models.DTOs;

public sealed class VillaCreateDTO
{
    [Required]
    [MaxLength(30, ErrorMessage = "Max length is 30 chars")]
    public string Name { get; set; } = "";
    public string? Details { get; set; }
    [Required]
    public double Rate { get; set; }
    public int Sqft { get; set; }
    public int Occupancy { get; set; }
    public string? ImageUrl { get; set; }
    public string? Amenity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
