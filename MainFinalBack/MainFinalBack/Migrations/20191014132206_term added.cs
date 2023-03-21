using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MainFinalBack.Migrations
{
    public partial class termAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Reviews",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 300);

            migrationBuilder.CreateTable(
                name: "TermHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Header = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TermContents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TermHeaderId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermContents_TermHeaders_TermHeaderId",
                        column: x => x.TermHeaderId,
                        principalTable: "TermHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TermContents_TermHeaderId",
                table: "TermContents",
                column: "TermHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TermContents");

            migrationBuilder.DropTable(
                name: "TermHeaders");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Reviews",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);
        }
    }
}
