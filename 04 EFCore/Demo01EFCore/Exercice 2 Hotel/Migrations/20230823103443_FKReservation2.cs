using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice_1_EFCore.Migrations
{
    public partial class FKReservation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Chambres_ChambreNumero",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ChambreNumero",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ChambreNumero",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChambreNumero",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ChambreNumero",
                table: "Reservations",
                column: "ChambreNumero");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Chambres_ChambreNumero",
                table: "Reservations",
                column: "ChambreNumero",
                principalTable: "Chambres",
                principalColumn: "ChambreNumero",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
