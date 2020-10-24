using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class editedreservationtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Table",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationTableId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReservationTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MaxGuest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationTables", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ReservationTableId",
                table: "Reservations",
                column: "ReservationTableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_ReservationTables_ReservationTableId",
                table: "Reservations",
                column: "ReservationTableId",
                principalTable: "ReservationTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_ReservationTables_ReservationTableId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "ReservationTables");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_ReservationTableId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationTableId",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "Table",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
