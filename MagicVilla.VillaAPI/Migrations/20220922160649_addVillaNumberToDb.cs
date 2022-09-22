using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    public partial class addVillaNumberToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8421), new DateTime(2022, 9, 23, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8459), new DateTime(2022, 9, 23, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8464), new DateTime(2022, 9, 23, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8469), new DateTime(2022, 9, 23, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 9, 23, 19, 36, 49, 473, DateTimeKind.Local).AddTicks(8475) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8222), new DateTime(2022, 9, 21, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8264), new DateTime(2022, 9, 21, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8270), new DateTime(2022, 9, 21, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8275), new DateTime(2022, 9, 21, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 20, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8280), new DateTime(2022, 9, 21, 14, 17, 31, 434, DateTimeKind.Local).AddTicks(8282) });
        }
    }
}
