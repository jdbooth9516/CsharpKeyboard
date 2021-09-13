using Microsoft.EntityFrameworkCore.Migrations;

namespace customKeyboard.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c21d049-cacb-4776-9595-7e6a435f8cb6", "0e2a7ccd-f826-4b1a-a3bc-b3bc7c590d65", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8404dfb-6abc-485f-a860-ea1dcdf6a03a", "b992716f-e89d-4013-a567-ee1c187e93eb", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c21d049-cacb-4776-9595-7e6a435f8cb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8404dfb-6abc-485f-a860-ea1dcdf6a03a");
        }
    }
}
