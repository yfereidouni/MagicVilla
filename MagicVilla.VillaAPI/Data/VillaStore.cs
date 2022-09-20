using MagicVilla.VillaAPI.Models.DTOs;

namespace MagicVilla.VillaAPI.Data;

public static class VillaStore
{
    public static List<VillaDTO> VillaList = new List<VillaDTO> {
        new VillaDTO
        {
            Id=1,
            Name = "Pool View",
            Details = "This villa is far from town.",
            Rate = 4.5,
            Amenity= "Yes",
            Occupancy=3,
            Sqft=120 ,
            CreatedDate=DateTime.Now,
            UpdatedDate = DateTime.Now.AddDays(1)
        },
        new VillaDTO
        {
            Id=2,
            Name = "Beach View",
            Details = "This villa is far from town.",
            Rate = 2.5,
            Amenity= "Yes",
            Occupancy=5,
            Sqft=300,
            CreatedDate=DateTime.Now,
            UpdatedDate = DateTime.Now.AddDays(1)
        }
    };
}
