using Microsoft.EntityFrameworkCore.Migrations;

namespace TALA.Server.Data.Migrations
{
    public partial class LisattiinsuoritusTaulu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Anto",
                table: "Tehtavat",
                newName: "Kuvaus");

            migrationBuilder.CreateTable(
                name: "Suoritukset",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TehtavaId = table.Column<int>(type: "int", nullable: false),
                    Suorituskerrat = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suoritukset", x => new { x.UserId, x.TehtavaId });
                    table.ForeignKey(
                        name: "FK_Suoritukset_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suoritukset_Tehtavat_TehtavaId",
                        column: x => x.TehtavaId,
                        principalTable: "Tehtavat",
                        principalColumn: "TehtavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Suoritukset_TehtavaId",
                table: "Suoritukset",
                column: "TehtavaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suoritukset");

            migrationBuilder.RenameColumn(
                name: "Kuvaus",
                table: "Tehtavat",
                newName: "Anto");
        }
    }
}
