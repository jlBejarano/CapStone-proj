using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalGrooming.Data.Migrations
{
    public partial class CustomerView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d4ced69-65a4-4c70-9862-3f66de487adf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9713076e-7f55-4c6d-944a-b54cdf842e8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f55aff-8f22-4cf6-beb2-58e33763bd19");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d0f55aff-8f22-4cf6-beb2-58e33763bd19", "7c70e36c-f193-4d37-9074-3d6822f4b6f6", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d4ced69-65a4-4c70-9862-3f66de487adf", "eb1d5cc8-c3dc-4fce-ab85-c90fea2a91bb", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9713076e-7f55-4c6d-944a-b54cdf842e8d", "b61e1b9f-4136-4521-a142-9abef2f49139", "Employee", "EMPLOYEE" });
        }
    }
}
