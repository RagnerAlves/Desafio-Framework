using Microsoft.EntityFrameworkCore;

namespace Desafio_Framework.DbEntities
{
    public class CRUDContext:DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new PacienteMap(modelBuilder.Entity<Paciente>());
        }
    }
}
