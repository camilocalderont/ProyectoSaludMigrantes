namespace ProyectoSaludMigrantes.Models
{
    public class DeclaracionesMigrantes
    {
        public long Id { get; set; }
        public string? FichaSisben { get; set; }            
        public string? Direccion { get; set; }  
        public string? Telefono { get; set; }  
        public long LocalidadId { get; set; } 
        public Localidad? Localidad { get; set; }
        public DateTime FechaDeclara { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}