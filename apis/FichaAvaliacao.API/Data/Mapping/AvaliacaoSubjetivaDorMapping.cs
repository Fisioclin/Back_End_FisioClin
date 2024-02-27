using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de AvaliacaoSubjetivaDor
    /// </summary>
    public class AvaliacaoSubjetivaDorMapping : IEntityTypeConfiguration<AvaliacaoSubjetivaDor>
    {
        public void Configure(EntityTypeBuilder<AvaliacaoSubjetivaDor> builder)
        {
            //Nome tabela 
            builder.ToTable("AvaliacaoSubjetivaDor");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Localizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.Caracteristicas).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Duracao).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.FatoresAgravantes).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.FatoresAtenuantes).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
