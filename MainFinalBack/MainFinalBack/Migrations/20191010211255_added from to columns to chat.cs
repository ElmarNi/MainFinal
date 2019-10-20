using Microsoft.EntityFrameworkCore.Migrations;

namespace MainFinalBack.Migrations
{
    public partial class addedfromtocolumnstochat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "To",
                table: "Chats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Chats");
        }
    }
}
