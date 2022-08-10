using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludMigrantes.Migrations
{
    public partial class FillDeclaracionMigrantesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"
                declare @i int  = (SELECT ISNULL(MAX(ID),0) + 1 FROM DECLARACIONES_MIGRANTES)
                update DECLARACIONES_MIGRANTES
                set ID  = @i , @i = @i + 1
                where ID is null                
            ");

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "DECLARACIONES_MIGRANTES",
                nullable: false
            );
            
            migrationBuilder.AddPrimaryKey(
                name: "PK_DECLARACION",
                table: "DECLARACIONES_MIGRANTES",
                column: "ID"
            );


            migrationBuilder.Sql(
            @"
                update DECLARACIONES_MIGRANTES
                set FECHA_VIGENCIA = DATEADD(MONTH , 4, FECHA_DECLARA)
                where FECHA_VIGENCIA is null              
            ");                 

            migrationBuilder.AlterColumn<DateTime>(
                name: "FECHA_VIGENCIA",
                table: "DECLARACIONES_MIGRANTES",
                type: "Date",
                nullable: false
            );            
                       
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropPrimaryKey(
                name: "PK_DECLARACION",
                table: "DECLARACIONES_MIGRANTES"                
            );

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                table: "DECLARACIONES_MIGRANTES",
                nullable: true
            );            
                        
            migrationBuilder.Sql(
            @"
                update DECLARACIONES_MIGRANTES
                set ID  = null
                where ID is not null                
            ");


            migrationBuilder.AlterColumn<DateTime>(
                name: "FECHA_VIGENCIA",
                table: "DECLARACIONES_MIGRANTES",
                type: "Date",
                nullable: true
            );             

            migrationBuilder.Sql(
            @"
                update DECLARACIONES_MIGRANTES
                set FECHA_VIGENCIA = null
                where FECHA_VIGENCIA is not null              
            ");             
        }
    }
}
