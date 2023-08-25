using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice_1_EFCore.Migrations
{
    public partial class PatchBoucleInfini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chambres_Clients_ClientId",
                table: "Chambres");

            migrationBuilder.DropIndex(
                name: "IX_Chambres_ClientId",
                table: "Chambres");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Chambres");

            migrationBuilder.RenameColumn(
                name: "Prenom",
                table: "Clients",
                newName: "prenom");

            migrationBuilder.RenameColumn(
                name: "Nom",
                table: "Clients",
                newName: "nom");

            migrationBuilder.RenameColumn(
                name: "NumeroTelephone",
                table: "Clients",
                newName: "numero_de_telephone");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tarif",
                table: "Chambres",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "prenom",
                table: "Clients",
                newName: "Prenom");

            migrationBuilder.RenameColumn(
                name: "nom",
                table: "Clients",
                newName: "Nom");

            migrationBuilder.RenameColumn(
                name: "numero_de_telephone",
                table: "Clients",
                newName: "NumeroTelephone");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tarif",
                table: "Chambres",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(14,2)",
                oldPrecision: 14,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Chambres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_ClientId",
                table: "Chambres",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chambres_Clients_ClientId",
                table: "Chambres",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
