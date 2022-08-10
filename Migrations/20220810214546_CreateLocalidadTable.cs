using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaludMigrantes.Migrations
{
    public partial class CreateLocalidadTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOCALIDAD",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCALIDAD", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "LOCALIDAD",
                columns: new[] { "ID", "NOMBRE" },
                values: new object[,]
                {
                    { 1L, "01. USAQUÉN" },
                    { 2L, "02. CHAPINERO" },
                    { 3L, "03. SANTA FE" },
                    { 4L, "04. SAN CRISTOBAL" },
                    { 5L, "05. USME" },
                    { 6L, "06. TUNJUELITO" },
                    { 7L, "07. BOSA" },
                    { 8L, "08. KENNEDY" },
                    { 9L, "09. FONTIBÓN" },
                    { 10L, "10. ENGATIVÁ" },
                    { 11L, "11. SUBA" },
                    { 12L, "12. BARRIOS UNIDOS" },
                    { 13L, "13. TEUSAQUILLO" },
                    { 14L, "14. MÁRTIRES" },
                    { 15L, "15. ANTONIO NARIÑO" },
                    { 16L, "16. PUENTE ARANDA" },
                    { 17L, "17. CANDELARIA" },
                    { 18L, "18. RAFAEL URIBE" },
                    { 19L, "19. CIUDAD BOLIVAR" },
                    { 29L, "20. SUMAPAZ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOCALIDAD");
        }
    }
}
