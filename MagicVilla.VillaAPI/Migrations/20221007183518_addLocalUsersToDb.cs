using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    public partial class addLocalUsersToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LocalUsers",
                columns: new[] { "Id", "Name", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "Yasser", "admin", "admin", "admin" },
                    { 2, "Majid", "user", "user", "user" }
                });

            migrationBuilder.InsertData(
                table: "VillaNumbers",
                columns: new[] { "VillaNo", "CreatedDate", "SpecialDetails", "UpdatedDate", "VillaId" },
                values: new object[,]
                {
                    { 101, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1207), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1209), 1 },
                    { 102, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1212), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1213), 1 },
                    { 103, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1216), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1218), 1 },
                    { 201, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1220), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1222), 2 },
                    { 202, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1224), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1225), 2 },
                    { 301, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1227), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1229), 3 },
                    { 401, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1231), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1232), 4 },
                    { 501, new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1234), "this is a dummy text.", new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1236), 5 }
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1052), "https://www.dotnetmastery.com/bluevillaimages/villa1.jpg", new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1089), "https://www.dotnetmastery.com/bluevillaimages/villa2.jpg", new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1093), "https://www.dotnetmastery.com/bluevillaimages/villa3.jpg", new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1098), "https://www.dotnetmastery.com/bluevillaimages/villa4.jpg", new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 7, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1102), "https://www.dotnetmastery.com/bluevillaimages/villa5.jpg", new DateTime(2022, 10, 8, 22, 5, 18, 41, DateTimeKind.Local).AddTicks(1104) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "VillaNumbers",
                keyColumn: "VillaNo",
                keyValue: 501);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3390), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg", new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3433), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3437), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg", new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3441), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3446), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg", new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3447) });
        }
    }
}
