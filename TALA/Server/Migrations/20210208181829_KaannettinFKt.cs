using Microsoft.EntityFrameworkCore.Migrations;

namespace TALA.Server.Migrations
{
    public partial class KaannettinFKt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tehtavat_Suoritukset_SuoritusId",
                table: "Tehtavat");

            migrationBuilder.DropIndex(
                name: "IX_Tehtavat_SuoritusId",
                table: "Tehtavat");

            migrationBuilder.DropColumn(
                name: "SuoritusId",
                table: "Tehtavat");

            migrationBuilder.AddColumn<int>(
                name: "TehtavaId",
                table: "Suoritukset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Suoritukset_TehtavaId",
                table: "Suoritukset",
                column: "TehtavaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suoritukset_Tehtavat_TehtavaId",
                table: "Suoritukset",
                column: "TehtavaId",
                principalTable: "Tehtavat",
                principalColumn: "TehtavaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Suoritukset_Tehtavat_TehtavaId",
                table: "Suoritukset");

            migrationBuilder.DropIndex(
                name: "IX_Suoritukset_TehtavaId",
                table: "Suoritukset");

            migrationBuilder.DropColumn(
                name: "TehtavaId",
                table: "Suoritukset");

            migrationBuilder.AddColumn<int>(
                name: "SuoritusId",
                table: "Tehtavat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tehtavat_SuoritusId",
                table: "Tehtavat",
                column: "SuoritusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tehtavat_Suoritukset_SuoritusId",
                table: "Tehtavat",
                column: "SuoritusId",
                principalTable: "Suoritukset",
                principalColumn: "SuoritusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
