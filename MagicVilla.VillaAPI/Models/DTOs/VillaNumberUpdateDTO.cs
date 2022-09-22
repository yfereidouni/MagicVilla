﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla.VillaAPI.Models.DTOs;

public class VillaNumberUpdateDTO
{
    [Required]
    public int VillaNo { get; set; }
    [Required]
    public int VillaId { get; set; }
    public string SpecialDetails { get; set; }
}