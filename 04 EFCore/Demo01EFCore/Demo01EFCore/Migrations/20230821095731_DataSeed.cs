using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo01EFCore.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Phone" },
                values: new object[] { 1000, "défaut@hotmail.fr", "Défaut", "Défaut", "0607080901" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1000);
        }
    }
}
