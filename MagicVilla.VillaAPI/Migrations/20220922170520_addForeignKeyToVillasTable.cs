using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla.VillaAPI.Migrations
{
    public partial class addForeignKeyToVillasTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaId",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers",
                column: "VillaId");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers",
                column: "VillaId",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaId",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaId",
                table: "VillaNumbers");

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
    }
}
