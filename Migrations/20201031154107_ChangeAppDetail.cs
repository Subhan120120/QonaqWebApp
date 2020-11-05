using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class ChangeAppDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarouselSubTitle1",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselSubTitle2",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselSubTitle3",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselSubTitle4",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselTitle1",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselTitle2",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselTitle3",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "CarouselTitle4",
                table: "AppDetails");

            migrationBuilder.AlterColumn<string>(
                name: "WebTitle",
                table: "AppDetails",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Twitter",
                table: "AppDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Instagram",
                table: "AppDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Facebook",
                table: "AppDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppDetails",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AppDetails",
                maxLength: 190,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AppDetails",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Heading",
                table: "AppDetails",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubHeading",
                table: "AppDetails",
                maxLength: 30,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "Heading",
                table: "AppDetails");

            migrationBuilder.DropColumn(
                name: "SubHeading",
                table: "AppDetails");

            migrationBuilder.AlterColumn<string>(
                name: "WebTitle",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Twitter",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Instagram",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Facebook",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 190,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselSubTitle1",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselSubTitle2",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselSubTitle3",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselSubTitle4",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselTitle1",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselTitle2",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselTitle3",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarouselTitle4",
                table: "AppDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
