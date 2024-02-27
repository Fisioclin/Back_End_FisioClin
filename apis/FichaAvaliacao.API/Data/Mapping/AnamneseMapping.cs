using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Anamnese
    /// </summary>
    public class AnamneseMapping : IEntityTypeConfiguration<Anamnese>
    {
        public void Configure(EntityTypeBuilder<Anamnese> builder)
        {
            //Nome tabela 
            builder.ToTable("Anamnese");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.DataLancamento).IsRequired();
            builder.Property(c => c.DataAtualizacao).IsRequired();
            builder.Property(c => c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.DiagnosticoClinico).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.CID10).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Peso).IsRequired();
            builder.Property(c => c.Altura).IsRequired();
            builder.Property(c => c.IMC).IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
