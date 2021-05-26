using Microsoft.EntityFrameworkCore.Migrations;

namespace Aps.Migrations
{
    public partial class AlteracaoEmDenuncias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContinenteId",
                table: "Denuncias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContinenteId",
                table: "Denuncias");
        }
    }
}
