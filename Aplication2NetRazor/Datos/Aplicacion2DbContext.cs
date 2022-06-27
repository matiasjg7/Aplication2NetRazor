using Aplication2NetRazor.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Aplication2NetRazor.Datos
{
    public class Aplicacion2DbContext : DbContext
    {
        public Aplicacion2DbContext(DbContextOptions<Aplicacion2DbContext> options) 
            : base(options)
        {
            
        }

        //Modelos
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Profesor> Profesor { get; set; }

    }
}
