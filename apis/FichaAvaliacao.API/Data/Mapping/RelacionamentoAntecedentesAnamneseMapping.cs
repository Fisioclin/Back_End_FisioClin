using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de RelacionamentoAntecedentesAnamnese
    /// </summary>
    public class RelacionamentoAntecedentesAnamneseMapping : IEntityTypeConfiguration<RelacionamentoAntecedentesAnamnese>
    {
        public void Configure(EntityTypeBuilder<RelacionamentoAntecedentesAnamnese> builder)
        {
            //Nome tabela 
            builder.ToTable("RelacionamentoAntecedentesAnamnese");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.GuidId).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioCriacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioAtualizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.AnamneseId).IsRequired();
            builder.Property(c => c.AntecedentesPessoaisId).IsRequired();
            builder.Property(c => c.Status).IsRequired();


            builder.HasOne(c => c.Anamnese)
              .WithMany(c => c.RelacionamentoAntecedentesAnamneses)
              .HasForeignKey(c => c.AnamneseId);

            builder.HasOne(c => c.AntecedentesPessoais)
              .WithMany(c => c.RelacionamentoAntecedentesAnamneses)
              .HasForeignKey(c => c.AntecedentesPessoaisId);

        }
    }
}
