using Microsoft.EntityFrameworkCore;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ganadero> Ganaderos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Finca> Fincas { get; set; }
        public DbSet<Ejemplar> Ejemplares { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Tratamiento> Tratamientos { get; set; }
        public DbSet<RegistroVacuna> RegistroVacunas { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }
        //public DbSet<Rol> Roles { get; set; }
        //public DbSet<Genero> Generos { get; set; }

        // Configuramos Conexion a Base de Datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Grupo31");
            }
        }
    }
}