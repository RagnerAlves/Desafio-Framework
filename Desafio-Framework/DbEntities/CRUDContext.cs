using Microsoft.EntityFrameworkCore;

namespace Desafio_Framework.DbEntities
{
    public class CRUDContext:DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options)
        {
           
        }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    new PacienteMap(modelBuilder.Entity<Paciente>());
        //    new PaisMap(modelBuilder.Entity<Pais>());
        //    new EstadoMap(modelBuilder.Entity<Estado>());
        //    new CidadeMap(modelBuilder.Entity<Cidade>());
        //}
    }
}
