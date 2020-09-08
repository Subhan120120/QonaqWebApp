using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class added_menuItemGroupId_to_menuItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuItems_MenuItemGroups_MenuItemGroupId",
                table: "MenuItems");

            migrationBuilder.AlterColumn<int>(
                name: "MenuItemGroupId",
                table: "MenuItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "MenuItemGroupId",
                table: "MenuItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MenuItems_MenuItemGroups_MenuItemGroupId",
                table: "MenuItems",
                column: "MenuItemGroupId",
                principalTable: "MenuItemGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
