using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class edited_table_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTableGroups_DineInTableGroupId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableId",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableGroupId",
                table: "Reservations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DineInTableGroups_DineInTableGroupId",
                table: "Reservations",
                column: "DineInTableGroupId",
                principalTable: "DineInTableGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations",
                column: "DineInTableId",
                principalTable: "DineInTables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTableGroups_DineInTableGroupId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_DineInTables_DineInTableId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DineInTableGroupId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

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
    }
}
