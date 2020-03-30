using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_Framework.DbEntities
{
    public class PacienteMap
    {
        public PacienteMap(EntityTypeBuilder<Paciente> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Nome).IsRequired();
            entityBuilder.Property(t => t.CPF).IsRequired();
            entityBuilder.Property(t => t.Pais).IsRequired();
            entityBuilder.Property(t => t.Estado).IsRequired();
            entityBuilder.Property(t => t.Cidade).IsRequired();
        }
    }
}