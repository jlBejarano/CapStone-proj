using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalGrooming.Data.Migrations
{
    public partial class AddedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d32a87e-30dc-4c8a-bac5-1bfa78aff9ce");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65928765-0645-410f-94e2-f0725484a2cc", "ff5d9040-0502-42a1-8b34-bbe7b216aa65", "Admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65928765-0645-410f-94e2-f0725484a2cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d32a87e-30dc-4c8a-bac5-1bfa78aff9ce", "93f708cc-9a93-4b4a-9757-1723484f2dfb", "Admin", "Admin" });
        }
    }
}
