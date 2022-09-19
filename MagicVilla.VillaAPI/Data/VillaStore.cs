using MagicVilla.VillaAPI.Models.DTOs;

namespace MagicVilla.VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> VillaList = new List<VillaDTO> {
        new VillaDTO {Id=1, Name = "Pool View" , Occupancy=3, Sqft=120 ,CreatedDate=DateTime.Now },
        new VillaDTO {Id=2, Name = "Beach View", Occupancy=5, Sqft=300, CreatedDate=DateTime.Now }
    };
}
