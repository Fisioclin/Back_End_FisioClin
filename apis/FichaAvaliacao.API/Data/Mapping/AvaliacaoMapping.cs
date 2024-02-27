using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Avaliacao
    /// </summary>
    public class AvaliacaoMapping : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            //Nome tabela 
            builder.ToTable("Avaliacao");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.GuidId).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioCriacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioAtualizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.Inspecao).HasColumnType("varchar(500)").IsRequired();
            builder.Property(c => c.Palpacao).HasColumnType("varchar(500)").IsRequired();
            builder.Property(c => c.FichaId).IsRequired();
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne(c => c.Ficha)
                .WithOne(c => c.Avaliacao)
                .HasForeignKey<Avaliacao>(c => c.FichaId);
        }
    }
}
