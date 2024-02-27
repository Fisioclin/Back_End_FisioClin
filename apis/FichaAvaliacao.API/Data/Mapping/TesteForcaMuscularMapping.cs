using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de TesteForcaMuscular
    /// </summary>
    public class TesteForcaMuscularMapping : IEntityTypeConfiguration<TesteForcaMuscular>
    {
        public void Configure(EntityTypeBuilder<TesteForcaMuscular> builder)
        {
            //Nome tabela 
            builder.ToTable("TesteForcaMuscular");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Grau).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
