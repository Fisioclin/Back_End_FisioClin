using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de AntecedentesFamiliares
    /// </summary>
    public class AntecedentesFamiliaresMapping : IEntityTypeConfiguration<AntecedentesFamiliares>
    {
        public void Configure(EntityTypeBuilder<AntecedentesFamiliares> builder)
        {
            //Nome tabela 
            builder.ToTable("AntecedentesFamiliares");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.DataLancamento).IsRequired();
            builder.Property(c => c.DataAtualizacao).IsRequired();
            builder.Property(c => c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
