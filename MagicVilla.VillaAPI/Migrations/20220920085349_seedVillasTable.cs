using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    public partial class seedVillasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2022, 9, 20, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5234), "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", "Royal Villa", 5, 200.0, 550, new DateTime(2022, 9, 21, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5313) },
                    { 2, "", new DateTime(2022, 9, 20, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5321), "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Diomond Villa", 4, 550.0, 900, new DateTime(2022, 9, 21, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5324) },
                    { 3, "", new DateTime(2022, 9, 20, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5329), "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", "Diomond Pool Villa", 4, 600.0, 1100, new DateTime(2022, 9, 21, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5332) },
                    { 4, "", new DateTime(2022, 9, 20, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5337), "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Roof Villa", 3, 800.0, 680, new DateTime(2022, 9, 21, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5340) },
                    { 5, "", new DateTime(2022, 9, 20, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5345), "Fusce 11 tincidunt maximus leo, sed scelerisque messa auctor sit. Donce ex damilar nur duch calliperist.", "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", "Beach Villa", 4, 650.0, 1100, new DateTime(2022, 9, 21, 13, 23, 49, 449, DateTimeKind.Local).AddTicks(5349) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
