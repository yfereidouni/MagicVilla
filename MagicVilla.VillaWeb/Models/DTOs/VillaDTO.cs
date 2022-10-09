using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaWeb.Models.DTOs;

public sealed class VillaDTO
{
    public int Id { get; set; }
    [Required]
    [MaxLength(30, ErrorMessage = "Max length is 30 chars")]
    public string Name { get; set; } = "";
    public string Details { get; set; }
    public double Rate { get; set; }
    public int Sqft { get; set; }
    public int Occupancy { get; set; }
    public string ImageUrl { get; set; }
    public string Amenity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
