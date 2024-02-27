using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Evolucao
    /// </summary>
    public class EvolucaoMapping : IEntityTypeConfiguration<Evolucao>
    {
        public void Configure(EntityTypeBuilder<Evolucao> builder)
        {
            //Nome tabela 
            builder.ToTable("Evolucao");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Observacao).HasColumnType("varchar(max)").IsRequired();
            builder.Property(c => c.DataEvolucao).IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
