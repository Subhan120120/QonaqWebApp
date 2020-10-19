using Microsoft.EntityFrameworkCore.Migrations;

namespace QonaqWebApp.Migrations
{
    public partial class added_appdetail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebTitle = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    About = table.Column<string>(nullable: true),
                    CarouselTitle1 = table.Column<string>(nullable: true),
                    CarouselSubTitle1 = table.Column<string>(nullable: true),
                    CarouselTitle2 = table.Column<string>(nullable: true),
                    CarouselSubTitle2 = table.Column<string>(nullable: true),
                    CarouselTitle3 = table.Column<string>(nullable: true),
                    CarouselSubTitle3 = table.Column<string>(nullable: true),
                    CarouselTitle4 = table.Column<string>(nullable: true),
                    CarouselSubTitle4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appDetails");
        }
    }
}
