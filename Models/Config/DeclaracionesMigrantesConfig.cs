using Microsoft.EntityFrameworkCore;
namespace ProyectoSaludMigrantes.Models.Config
{
    public class DeclaracionesMigrantesConfig
    {
        public DeclaracionesMigrantesConfig(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeclaracionesMigrantes>(entidad=>{
                entidad.ToTable("DECLARACIONES_MIGRANTES");
                entidad.Property(x=>x.Id).HasColumnName("ID").IsRequired();
                entidad.HasKey(x=>x.Id);
                entidad.Property(x=>x.FichaSisben).HasColumnName("FICHA_SISBEN").IsRequired().HasMaxLength(30);               
                entidad.Property(x=>x.Direccion).HasColumnName("DIRECCION").HasMaxLength(250); 
                entidad.Property(x=>x.Telefono).HasColumnName("TELEFONO").HasMaxLength(30); 
                entidad.Property(x=>x.LocalidadId).HasColumnName("LOCALIDAD"); 
                entidad.Property(x=>x.FechaDeclara).HasColumnName("FECHA_DECLARA").HasColumnType("Date").IsRequired(); 
                entidad.Property(x=>x.FechaVigencia).HasColumnName("FECHA_VIGENCIA").HasColumnType("Date").IsRequired(); 
            });            
        }          
    }
}