using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class dineIntablesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DineInTableGroupId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DineInTableId",
                table: "Reservations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DineInTableGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MaxGuest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInTableGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DineInTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    MaxGuest = table.Column<int>(nullable: false),
                    DineInTableGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DineInTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DineInTables_DineInTableGroups_DineInTableGroupId",
                        column: x => x.DineInTableGroupId,
                        principalTable: "DineInTableGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DineInTableGroupId",
                table: "Reservations",
                column: "DineInTableGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DineInTableId",
                table: "Reservations",
                column: "DineInTableId");

            migrationBuilder.CreateIndex(
                name: "IX_DineInTables_DineInTableGroupId",
                table: "DineInTables",
                column: "DineInTableGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DineInTableGroups_DineInTableGroupId",
                table: "Reservations",
                column: "DineInTableGroupId",
                principalTable: "DineInTableGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations",
                column: "DineInTableId",
                principalTable: "DineInTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTableGroups_DineInTableGroupId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations");

            migrationBuilder.DropTable(
                name: "DineInTables");

            migrationBuilder.DropTable(
                name: "DineInTableGroups");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DineInTableGroupId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DineInTableId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DineInTableGroupId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DineInTableId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationTableId",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ReservationTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxGuest = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
