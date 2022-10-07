using MagicVilla.VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla.VillaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Villa> Villas { get; set; }
    public DbSet<VillaNumber> VillaNumbers { get; set; }
    public DbSet<LocalUser> LocalUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Villa>().HasData(
            new Villa
            {
                Id = 1,
                Name = "Royal Villa",
                Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa1.jpg",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
            },
            new Villa
            {
                Id = 2,
                Name = "Peremium Pool Villa",
                Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa2.jpg",
                Occupancy = 4,
                Rate = 550,
                Sqft = 900,
                Amenity = "",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
            },
            new Villa
            {
                Id = 3,
                Name = "Luxary Pool Villa",
                Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa3.jpg",
                Occupancy = 4,
                Rate = 600,
                Sqft = 1100,
                Amenity = "",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
            },
            new Villa
            {
                Id = 4,
                Name = "Diamond Villa",
                Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa4.jpg",
                Occupancy = 3,
                Rate = 800,
                Sqft = 680,
                Amenity = "",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
            },
            new Villa
            {
                Id = 5,
                Name = "Diamond Pool Villa",
                Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa5.jpg",
                Occupancy = 4,
                Rate = 650,
                Sqft = 1100,
                Amenity = "",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now.AddDays(1),
            }
            );

        modelBuilder.Entity<VillaNumber>().HasData(
            new VillaNumber
            {
                VillaNo = 101,
                VillaId = 1,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 102,
                VillaId = 1,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 103,
                VillaId = 1,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 201,
                VillaId = 2,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 202,
                VillaId = 2,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 301,
                VillaId = 3,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 401,
                VillaId = 4,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            },
            new VillaNumber
            {
                VillaNo = 501,
                VillaId = 5,
                SpecialDetails = "this is a dummy text.",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            }
            );

        modelBuilder.Entity<LocalUser>().HasData(
            new LocalUser
            {
                Id = 1,
                Name = "Yasser",
                UserName = "admin",
                Password = "admin",
                Role = "admin"
            }, 
            new LocalUser
            {
                Id = 2,
                Name = "Majid",
                UserName = "user",
                Password = "user",
                Role = "user"
            }
            );
    }
}
