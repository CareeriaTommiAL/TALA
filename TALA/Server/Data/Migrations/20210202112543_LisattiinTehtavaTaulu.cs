using Microsoft.EntityFrameworkCore.Migrations;

namespace TALA.Server.Data.Migrations
{
    public partial class LisattiinTehtavaTaulu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tehtavat",
                columns: table => new
                {
                    TehtavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Anto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tehtavat", x => x.TehtavaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tehtavat");
        }
    }
}
