using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exercice_1_EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelephone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chambres",
                columns: table => new
                {
                    ChambreNumero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLits = table.Column<int>(type: "int", nullable: false),
                    Tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chambres", x => x.ChambreNumero);
                    table.ForeignKey(
                        name: "FK_Chambres_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Statut = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservationChambres",
                columns: table => new
                {
                    ChambreNumero = table.Column<int>(type: "int", nullable: false),
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationChambres", x => new { x.ChambreNumero, x.ReservationId });
                    table.ForeignKey(
                        name: "FK_ReservationChambres_Chambres_ChambreNumero",
                        column: x => x.ChambreNumero,
                        principalTable: "Chambres",
                        principalColumn: "ChambreNumero",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservationChambres_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Chambres",
                columns: new[] { "ChambreNumero", "ClientId", "NombreLits", "Statut", "Tarif" },
                values: new object[,]
                {
                    { 1, 0, 2, 0, 100.50m },
                    { 2, 0, 4, 2, 400.50m }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Nom", "NumeroTelephone", "Prenom" },
                values: new object[,]
                {
                    { 1, "Dupont", "0607080910", "Pierre" },
                    { 2, "Abadi", "0607080911", "Ihab" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chambres_ClientId",
                table: "Chambres",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservationChambres_ReservationId",
                table: "ReservationChambres",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ClientId",
                table: "Reservations",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReservationChambres");

            migrationBuilder.DropTable(
                name: "Chambres");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
