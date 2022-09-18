using MagicVilla.VillaAPI.Models.DTOs;

namespace MagicVilla.VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> VillaList = new List<VillaDTO> {
        new VillaDTO {Id=1, Name = "Pool View" ,CreatedDate=DateTime.Now },
        new VillaDTO {Id=2, Name = "Beach View",CreatedDate=DateTime.Now }
    };
}
