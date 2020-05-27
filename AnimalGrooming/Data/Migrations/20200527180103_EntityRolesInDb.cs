using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalGrooming.Data.Migrations
{
    public partial class EntityRolesInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65928765-0645-410f-94e2-f0725484a2cc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bfb33d47-b4cb-4c7a-9818-6bf402b1b576", "1c3c9c14-5fa8-4bf0-837a-30eaba50e61e", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1ffa8510-de7e-46b4-a366-c6731f4936bd", "ac86e9a0-b865-465c-980e-a308683b4cbf", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ebe5debd-a5ce-4497-9211-69bfb0f0c4a5", "1b1189ff-5225-490f-9053-e0085568876a", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ffa8510-de7e-46b4-a366-c6731f4936bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfb33d47-b4cb-4c7a-9818-6bf402b1b576");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ebe5debd-a5ce-4497-9211-69bfb0f0c4a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "65928765-0645-410f-94e2-f0725484a2cc", "ff5d9040-0502-42a1-8b34-bbe7b216aa65", "Admin", "Admin" });
        }
    }
}
