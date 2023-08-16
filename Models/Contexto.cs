using Microsoft.EntityFrameworkCore;

namespace WMVCBCCT22023.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): 
            base(options) { }

        public DbSet<Curso> Cursos{ get; set; }

        public DbSet<Sala> Salas { get; set; }


    }
}
