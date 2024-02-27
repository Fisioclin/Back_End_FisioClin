using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de ObjetivosCondutas
    /// </summary>
    public class ObjetivosCondutasMapping : IEntityTypeConfiguration<ObjetivosCondutas>
    {
        public void Configure(EntityTypeBuilder<ObjetivosCondutas> builder)
        {
            //Nome tabela 
            builder.ToTable("ObjetivosCondutas");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.DataLancamento).IsRequired();
            builder.Property(c => c.DataAtualizacao).IsRequired();
            builder.Property(c => c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.DiagnosticoTerapeutico).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.ObjetivosTratamento).HasColumnType("varchar(500)").IsRequired();
            builder.Property(c => c.CondutaFisioterapeutica).HasColumnType("varchar(1000)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
