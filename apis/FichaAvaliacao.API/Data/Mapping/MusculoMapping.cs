using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Musculo
    /// </summary>
    public class MusculoMapping : IEntityTypeConfiguration<Musculo>
    {
        public void Configure(EntityTypeBuilder<Musculo> builder)
        {
            //Nome tabela 
            builder.ToTable("Musculo");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Descricao).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Status).IsRequired();

        }
    }
}
