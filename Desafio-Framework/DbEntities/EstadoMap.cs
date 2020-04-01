using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_Framework.DbEntities
{
    public class EstadoMap
    {
        public EstadoMap(EntityTypeBuilder<Estado> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Descricao).IsRequired();
            entityBuilder.Property(t => t.Pais).IsRequired();
        }
    }
}