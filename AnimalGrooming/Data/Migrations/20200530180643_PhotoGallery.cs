using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalGrooming.Data.Migrations
{
    public partial class PhotoGallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1232f9b-e7cf-4c7c-8fa5-0992c5144c1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6cbb59e-5cc0-47bc-8fd0-1126dd37f835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d839d344-c35f-40d0-8345-f90963ad9c34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d899bb8b-df8b-48a1-b47c-67bf997d9d0e", "c4fc1922-5cc7-455c-b150-d0feaa4ff2e9", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16e4711b-ac62-45d3-8c2e-3aff55d95442", "d9fb0a33-7b25-487e-85ed-0a16a9be0fa9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d21f48f7-a97d-4fdd-9272-ac2bdff08f43", "02d85f29-f101-4616-84ad-aafdceb78a3f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16e4711b-ac62-45d3-8c2e-3aff55d95442");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21f48f7-a97d-4fdd-9272-ac2bdff08f43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d899bb8b-df8b-48a1-b47c-67bf997d9d0e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1232f9b-e7cf-4c7c-8fa5-0992c5144c1d", "2c0c4ff2-dd91-47aa-af2c-eab1480881c2", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6cbb59e-5cc0-47bc-8fd0-1126dd37f835", "f793750a-d919-46f5-97f7-564e58d53bd9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d839d344-c35f-40d0-8345-f90963ad9c34", "3f2eb4a3-87c4-4d0a-99c9-ab129c7d5239", "Employee", "EMPLOYEE" });
        }
    }
}
