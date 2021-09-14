using Microsoft.EntityFrameworkCore.Migrations;

namespace customKeyboard.Migrations
{
    public partial class fixedcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01431279-6eef-4249-9efc-ecabea9dd54f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bdd4c75d-1e33-4a51-9150-ca2bf807ff42");

            migrationBuilder.CreateTable(
                name: "Builds",
                columns: table => new
                {
                    BuildsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BuildPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Builds", x => x.BuildsId);
                    table.ForeignKey(
                        name: "FK_Builds_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: false),
                    userId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.ShippingAddressId);
                    table.ForeignKey(
                        name: "FK_ShippingAddress_AspNetUsers_userId1",
                        column: x => x.userId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "330a3649-24ec-4ba8-8a13-ad434568af63", "594b2782-3d76-4f20-bb31-85cafbda6d79", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59ba8ecb-94f1-4281-9c2f-1b0ac07a81ee", "884e7eb8-a529-4202-b4f8-f9f7d4fe8116", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Builds_ProductId",
                table: "Builds",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingAddress_userId1",
                table: "ShippingAddress",
                column: "userId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Builds");

            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330a3649-24ec-4ba8-8a13-ad434568af63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59ba8ecb-94f1-4281-9c2f-1b0ac07a81ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01431279-6eef-4249-9efc-ecabea9dd54f", "72bd6e73-0fda-4a9f-9ca8-8e53eeb8e540", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bdd4c75d-1e33-4a51-9150-ca2bf807ff42", "8cbd6338-a121-454d-b49e-92ff907cd6c2", "Employee", "EMPLOYEE" });
        }
    }
}
