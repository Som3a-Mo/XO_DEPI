using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XO_DEPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "battles",
                columns: table => new
                {
                    FirstPlayer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SecondPlayer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstPlayerScore = table.Column<int>(type: "int", nullable: false),
                    SecondPlayerScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_battles", x => new { x.FirstPlayer, x.SecondPlayer });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "battles");
        }
    }
}
