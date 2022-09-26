using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaWeb.Models.DTOs;

public class VillaUpdateDTO
{
    [Required]
    public int Id { get; set; }
    [Required]
    [MaxLength(30, ErrorMessage = "Max length is 30 chars")]
    public string Name { get; set; } = "";
    public string Details { get; set; }
    [Required]
    public double Rate { get; set; }
    [Required]
    public int Sqft { get; set; }
    [Required]
    public int Occupancy { get; set; }
    [Required]
    public string ImageUrl { get; set; }
    public string Amenity { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
