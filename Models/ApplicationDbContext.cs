using Microsoft.EntityFrameworkCore;
using ProyectoSaludMigrantes.Models.Config;
namespace ProyectoSaludMigrantes.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        } 
        public DbSet<Localidad> Localidad { get; set;} 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new LocalidadConfig(modelBuilder);            
        }        
    }
}