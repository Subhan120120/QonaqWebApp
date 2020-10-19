using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appDetails",
                table: "appDetails");

            migrationBuilder.RenameTable(
                name: "appDetails",
                newName: "AppDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppDetails",
                table: "AppDetails",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppDetails",
                table: "AppDetails");

            migrationBuilder.RenameTable(
                name: "AppDetails",
                newName: "appDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appDetails",
                table: "appDetails",
                column: "Id");
        }
    }
}
