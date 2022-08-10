using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludMigrantes.Migrations
{
    public partial class UpdateDeclaracionMigrantesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ID",
                table: "DECLARACIONES_MIGRANTES",
                nullable: true
            );
            migrationBuilder.AddColumn<DateTime>(
                name: "FECHA_VIGENCIA",
                table: "DECLARACIONES_MIGRANTES",
                type: "Date",
                nullable: true
            );
            /*
            migrationBuilder.AddPrimaryKey(
                name: "PK_DECLARACION",
                table: "DECLARACIONES_MIGRANTES",
                column: "ID"
            );
            */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DropPrimaryKey(
                name: "PK_DECLARACION",
                table: "DECLARACIONES_MIGRANTES"                
            );
            */

            migrationBuilder.DropColumn(
                name: "ID",
                table: "DECLARACIONES_MIGRANTES"                
            );

            migrationBuilder.DropColumn(
                name: "FECHA_VIGENCIA",
                table: "DECLARACIONES_MIGRANTES"               
            );            
                                
        }
    }
}
