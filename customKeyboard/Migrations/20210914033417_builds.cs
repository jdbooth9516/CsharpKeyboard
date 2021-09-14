using Microsoft.EntityFrameworkCore.Migrations;

namespace customKeyboard.Migrations
{
    public partial class builds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b556ae6-ed36-47c6-92de-8b696cfe9fed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e627f33d-316f-4e50-839d-1898b5743c90");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01431279-6eef-4249-9efc-ecabea9dd54f", "72bd6e73-0fda-4a9f-9ca8-8e53eeb8e540", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdd4c75d-1e33-4a51-9150-ca2bf807ff42", "8cbd6338-a121-454d-b49e-92ff907cd6c2", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01431279-6eef-4249-9efc-ecabea9dd54f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdd4c75d-1e33-4a51-9150-ca2bf807ff42");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e627f33d-316f-4e50-839d-1898b5743c90", "bc50aaab-3ce3-42b1-b63c-fd2a68f2aa15", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b556ae6-ed36-47c6-92de-8b696cfe9fed", "a5cb647a-3799-42a8-92f0-8d685b299ef6", "Employee", "EMPLOYEE" });
        }
    }
}
