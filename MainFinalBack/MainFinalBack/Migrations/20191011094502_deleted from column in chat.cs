using Microsoft.EntityFrameworkCore.Migrations;

namespace MainFinalBack.Migrations
{
    public partial class deletedFromcolumninchat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "From",
                table: "Chats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "From",
                table: "Chats",
                nullable: true);
        }
    }
}
