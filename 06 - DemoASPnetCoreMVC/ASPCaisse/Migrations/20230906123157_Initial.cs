using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPASPCaisse.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    quantity = table.Column<int>(type: "int", precision: 10, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => new { x.id, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_product_category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "id", "name" },
                values: new object[] { 1, "Fruits" });

            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "id", "name" },
                values: new object[] { 2, "Légumes" });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "CategoryId", "id", "description", "ImageUrl", "name", "price", "quantity" },
                values: new object[] { 1, 1, "Fruit qui vient du bananier", null, "Banane", 1m, 100 });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "CategoryId", "id", "description", "ImageUrl", "name", "price", "quantity" },
                values: new object[] { 1, 2, "Fruit qui vient du fraisier", null, "Fraise", 1m, 100 });

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
