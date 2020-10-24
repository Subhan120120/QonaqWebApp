using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class dineIntablesupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hall",
                table: "Reservations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hall",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
