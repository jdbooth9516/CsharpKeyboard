using Microsoft.EntityFrameworkCore.Migrations;

namespace customKeyboard.Migrations
{
    public partial class shoppingCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330a3649-24ec-4ba8-8a13-ad434568af63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59ba8ecb-94f1-4281-9c2f-1b0ac07a81ee");

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ShoppingCartsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BuildsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ShoppingCartsId);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_Builds_BuildsId",
                        column: x => x.BuildsId,
                        principalTable: "Builds",
                        principalColumn: "BuildsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6ee1141-76c3-410b-9103-3a2101e70d2e", "15b8ae29-5e5f-4681-bf60-5959b7207915", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7623f11f-a276-46c7-a635-6d5aac2f6f56", "97bbe2c3-c0d7-4b15-a6e8-15ae3ed4d4c3", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_BuildsId",
                table: "ShoppingCarts",
                column: "BuildsId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_UserId",
                table: "ShoppingCarts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7623f11f-a276-46c7-a635-6d5aac2f6f56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6ee1141-76c3-410b-9103-3a2101e70d2e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "330a3649-24ec-4ba8-8a13-ad434568af63", "594b2782-3d76-4f20-bb31-85cafbda6d79", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59ba8ecb-94f1-4281-9c2f-1b0ac07a81ee", "884e7eb8-a529-4202-b4f8-f9f7d4fe8116", "Employee", "EMPLOYEE" });
        }
    }
}
