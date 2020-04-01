using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio_Framework.DbEntities
{
    public class CidadeMap
    {
        public CidadeMap(EntityTypeBuilder<Cidade> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Descricao).IsRequired();
            entityBuilder.Property(t => t.Estado).IsRequired();
        }
    }
}