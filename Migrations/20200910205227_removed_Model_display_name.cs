using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class removed_Model_display_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menular_MenuItemGroups_MenuItemGroupId",
                table: "Menular");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menular",
                table: "Menular");

            migrationBuilder.RenameTable(
                name: "Menular",
                newName: "MenuItems");

            migrationBuilder.RenameIndex(
                name: "IX_Menular_MenuItemGroupId",
                table: "MenuItems",
                newName: "IX_MenuItems_MenuItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MenuItemGroups_MenuItemGroupId",
                table: "MenuItems",
                column: "MenuItemGroupId",
                principalTable: "MenuItemGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MenuItemGroups_MenuItemGroupId",
                table: "MenuItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems");

            migrationBuilder.RenameTable(
                name: "MenuItems",
                newName: "Menular");

            migrationBuilder.RenameIndex(
                name: "IX_MenuItems_MenuItemGroupId",
                table: "Menular",
                newName: "IX_Menular_MenuItemGroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menular",
                table: "Menular",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Menular_MenuItemGroups_MenuItemGroupId",
                table: "Menular",
                column: "MenuItemGroupId",
                principalTable: "MenuItemGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
