using Microsoft.EntityFrameworkCore.Migrations;

namespace MainFinalBack.Migrations
{
    public partial class addedOurpassionsectionbannercolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SectionBannerImage",
                table: "OurPassions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectionBannerImage",
                table: "OurPassions");
        }
    }
}
