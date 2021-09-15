using Microsoft.EntityFrameworkCore.Migrations;

namespace customKeyboard.Migrations
{
    public partial class fixedbuilds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7623f11f-a276-46c7-a635-6d5aac2f6f56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6ee1141-76c3-410b-9103-3a2101e70d2e");

            migrationBuilder.DropColumn(
                name: "BuildPrice",
                table: "Builds");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Builds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f378ccc-21bc-49ae-a905-3c223bd3130f", "68af7d16-346a-4f5d-b9d3-6ee91a0d8999", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58981cd2-282a-442a-b32e-32b658bc9bb4", "b52b6b49-1a50-4362-bcd2-c3fc276f492f", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58981cd2-282a-442a-b32e-32b658bc9bb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f378ccc-21bc-49ae-a905-3c223bd3130f");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Builds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "BuildPrice",
                table: "Builds",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6ee1141-76c3-410b-9103-3a2101e70d2e", "15b8ae29-5e5f-4681-bf60-5959b7207915", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7623f11f-a276-46c7-a635-6d5aac2f6f56", "97bbe2c3-c0d7-4b15-a6e8-15ae3ed4d4c3", "Employee", "EMPLOYEE" });
        }
    }
}
