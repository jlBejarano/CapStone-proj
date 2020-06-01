using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalGrooming.Data.Migrations
{
    public partial class CreateReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalWeight = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalBreed = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalWeight);
                    table.ForeignKey(
                        name: "FK_Animal_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50e94e83-b51f-46b6-ac83-69b3aa3e02e5", "536bb8cf-2206-43d2-899e-d26ad66b078b", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a65ed541-6eff-4f67-ba0e-37f818a3a24c", "d905e987-f09a-4e8c-b993-a0e6535ac2e7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "93c48361-1582-45e3-bc88-8d7f34b9e8c6", "2ffe1572-4c6f-46d9-b5de-2753908645be", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_CustomerId",
                table: "Animal",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_IdentityUserId",
                table: "Review",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50e94e83-b51f-46b6-ac83-69b3aa3e02e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93c48361-1582-45e3-bc88-8d7f34b9e8c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a65ed541-6eff-4f67-ba0e-37f818a3a24c");

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
    }
}
