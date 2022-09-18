using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaAPI.Models.DTOs;

public class VillaDTO
{
    public int Id { get; set; }
    [Required]
    [MaxLength(20,ErrorMessage ="Max length is 20 chars")]
    public string Name { get; set; } = "";
    public DateTime CreatedDate { get; set; }
}
