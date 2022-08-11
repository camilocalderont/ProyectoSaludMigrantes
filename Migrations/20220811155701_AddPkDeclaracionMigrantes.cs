using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludMigrantes.Migrations
{
    public partial class AddPkDeclaracionMigrantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "IDX_FICHA_SISBEN",
                table: "DECLARACIONES_MIGRANTES",
                column: "FICHA_SISBEN"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "IDX_FICHA_SISBEN",
                table: "DECLARACIONES_MIGRANTES"                
            );
        }
    }
}
