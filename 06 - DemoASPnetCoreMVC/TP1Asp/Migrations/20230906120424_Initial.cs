using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP1Asp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todolist",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre_task = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todolist", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "todolist",
                columns: new[] { "id", "desc", "titre_task" },
                values: new object[] { 1, "Cuisiner du poulet aux olives", "Faire à manger" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todolist");
        }
    }
}
