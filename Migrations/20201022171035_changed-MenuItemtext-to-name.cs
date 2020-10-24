using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class changedMenuItemtexttoname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuItemText",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "MenuItemGroupText",
                table: "MenuItemGroups");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DineInTables");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DineInTableGroups");

            migrationBuilder.AddColumn<string>(
                name: "MenuItemName",
                table: "MenuItems",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuItemGroupName",
                table: "MenuItemGroups",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "DineInTables",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableGroupName",
                table: "DineInTableGroups",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuItemName",
                table: "MenuItems");

            migrationBuilder.DropColumn(
                name: "MenuItemGroupName",
                table: "MenuItemGroups");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "DineInTables");

            migrationBuilder.DropColumn(
                name: "TableGroupName",
                table: "DineInTableGroups");

            migrationBuilder.AddColumn<string>(
                name: "MenuItemText",
                table: "MenuItems",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MenuItemGroupText",
                table: "MenuItemGroups",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DineInTables",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DineInTableGroups",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");
        }
    }
}
