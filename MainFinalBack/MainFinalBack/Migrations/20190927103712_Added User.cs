using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MainFinalBack.Migrations
{
    public partial class AddedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppliacationUserId",
                table: "Advertisements",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppliacationUser",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliacationUser", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_AppliacationUserId",
                table: "Advertisements",
                column: "AppliacationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Advertisements_AppliacationUser_AppliacationUserId",
                table: "Advertisements",
                column: "AppliacationUserId",
                principalTable: "AppliacationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advertisements_AppliacationUser_AppliacationUserId",
                table: "Advertisements");

            migrationBuilder.DropTable(
                name: "AppliacationUser");

            migrationBuilder.DropIndex(
                name: "IX_Advertisements_AppliacationUserId",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "AppliacationUserId",
                table: "Advertisements");
        }
    }
}
