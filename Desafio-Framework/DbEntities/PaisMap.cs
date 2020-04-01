using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_Framework.DbEntities
{
    public class PaisMap
    {
        public PaisMap(EntityTypeBuilder<Pais> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Descricao).IsRequired();
        }
    }
}