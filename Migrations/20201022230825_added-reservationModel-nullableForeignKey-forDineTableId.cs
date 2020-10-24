using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class addedreservationModelnullableForeignKeyforDineTableId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableId",
                table: "Reservations",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations",
                column: "DineInTableId",
                principalTable: "DineInTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
