using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    public partial class changeNullableToFalse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3433), new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3441), new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 10, 1, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 10, 2, 19, 24, 58, 163, DateTimeKind.Local).AddTicks(3447) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Details",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Amenity",
                table: "Villas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialDetails",
                table: "VillaNumbers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 9, 23, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9982), new DateTime(2022, 9, 23, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9988), new DateTime(2022, 9, 23, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9992), new DateTime(2022, 9, 23, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9996), new DateTime(2022, 9, 23, 20, 35, 19, 752, DateTimeKind.Local).AddTicks(9998) });
        }
    }
}
