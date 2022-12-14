// <auto-generated />
using System;
using MagicVilla.VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MagicVilla.VillaAPI.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yasser",
                            Password = "admin",
                            Role = "admin",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Majid",
                            Password = "user",
                            Role = "user",
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("MagicVilla.VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1052),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                            ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa1.jpg",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedDate = new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1085)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1089),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                            ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa2.jpg",
                            Name = "Peremium Pool Villa",
                            Occupancy = 4,
                            Rate = 550.0,
                            Sqft = 900,
                            UpdatedDate = new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1091)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1093),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                            ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa3.jpg",
                            Name = "Luxary Pool Villa",
                            Occupancy = 4,
                            Rate = 600.0,
                            Sqft = 1100,
                            UpdatedDate = new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1095)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1098),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                            ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa4.jpg",
                            Name = "Diamond Villa",
                            Occupancy = 3,
                            Rate = 800.0,
                            Sqft = 680,
                            UpdatedDate = new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1099)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1102),
                            Details = "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.",
                            ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa5.jpg",
                            Name = "Diamond Pool Villa",
                            Occupancy = 4,
                            Rate = 650.0,
                            Sqft = 1100,
                            UpdatedDate = new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1104)
                        });
                });

            modelBuilder.Entity("MagicVilla.VillaAPI.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("VillaNumbers");

                    b.HasData(
                        new
                        {
                            VillaNo = 101,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1207),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1209),
                            VillaId = 1
                        },
                        new
                        {
                            VillaNo = 102,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1212),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1213),
                            VillaId = 1
                        },
                        new
                        {
                            VillaNo = 103,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1216),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1218),
                            VillaId = 1
                        },
                        new
                        {
                            VillaNo = 201,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1220),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1222),
                            VillaId = 2
                        },
                        new
                        {
                            VillaNo = 202,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1224),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1225),
                            VillaId = 2
                        },
                        new
                        {
                            VillaNo = 301,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1227),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1229),
                            VillaId = 3
                        },
                        new
                        {
                            VillaNo = 401,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1231),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1232),
                            VillaId = 4
                        },
                        new
                        {
                            VillaNo = 501,
                            CreatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1234),
                            SpecialDetails = "this is a dummy text.",
                            UpdatedDate = new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1236),
                            VillaId = 5
                        });
                });

            modelBuilder.Entity("MagicVilla.VillaAPI.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla.VillaAPI.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
