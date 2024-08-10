using Microsoft.EntityFrameworkCore;

namespace MVCProyecto.Models
{
    public class ProyectoDBContext : DbContext
    {
        public ProyectoDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Asignacion> Asignaciones { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
    }
}
