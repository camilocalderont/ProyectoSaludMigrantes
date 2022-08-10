using Microsoft.EntityFrameworkCore;
namespace ProyectoSaludMigrantes.Models.Config
{
    public class LocalidadConfig
    {
        public LocalidadConfig(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Localidad>(entidad=>{
                entidad.ToTable("LOCALIDAD");
                entidad.Property(x=>x.Id).HasColumnName("ID").IsRequired();
                entidad.Property(x=>x.Nombre).HasColumnName("NOMBRE").IsRequired();

                entidad.HasData(
                    new Localidad
                    {
                        Id=1,
                        Nombre="01. USAQUÉN",
                    },
                    new Localidad
                    {
                        Id=2,
                        Nombre="02. CHAPINERO",
                    },
                    new Localidad
                    {
                        Id=3,
                        Nombre="03. SANTA FE",
                    },
                    new Localidad
                    {
                        Id=4,
                        Nombre="04. SAN CRISTOBAL",
                    },
                    new Localidad
                    {
                        Id=5,
                        Nombre="05. USME",
                    },
                    new Localidad
                    {
                        Id=6,
                        Nombre="06. TUNJUELITO",
                    },
                    new Localidad
                    {
                        Id=7,
                        Nombre="07. BOSA",
                    },
                    new Localidad
                    {
                        Id=8,
                        Nombre="08. KENNEDY",
                    },
                    new Localidad
                    {
                        Id=9,
                        Nombre="09. FONTIBÓN",
                    },
                    new Localidad
                    {
                        Id=10,
                        Nombre="10. ENGATIVÁ",
                    },
                    new Localidad
                    {
                        Id=11,
                        Nombre="11. SUBA",
                    },
                    new Localidad
                    {
                        Id=12,
                        Nombre="12. BARRIOS UNIDOS",
                    },
                    new Localidad
                    {
                        Id=13,
                        Nombre="13. TEUSAQUILLO",
                    },
                    new Localidad
                    {
                        Id=14,
                        Nombre="14. MÁRTIRES",
                    },
                    new Localidad
                    {
                        Id=15,
                        Nombre="15. ANTONIO NARIÑO",
                    },
                    new Localidad
                    {
                        Id=16,
                        Nombre="16. PUENTE ARANDA",
                    },
                    new Localidad
                    {
                        Id=17,
                        Nombre="17. CANDELARIA",
                    },
                    new Localidad
                    {
                        Id=18,
                        Nombre="18. RAFAEL URIBE",
                    },
                    new Localidad
                    {
                        Id=19,
                        Nombre="19. CIUDAD BOLIVAR",
                    },
                    new Localidad
                    {
                        Id=29,
                        Nombre="20. SUMAPAZ",
                    }                    
                );
            });
            
        }        
    }
}