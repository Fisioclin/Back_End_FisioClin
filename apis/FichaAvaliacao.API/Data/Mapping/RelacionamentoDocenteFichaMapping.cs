using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de RelacionamentoDocenteFicha
    /// </summary>
    public class RelacionamentoDocenteFichaMapping : IEntityTypeConfiguration<RelacionamentoDocenteFicha>
    {
        public void Configure(EntityTypeBuilder<RelacionamentoDocenteFicha> builder)
        {
            //Nome tabela 
            builder.ToTable("RelacionamentoDocenteFicha");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.GuidId).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioCriacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioAtualizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.FichaId).IsRequired();
            builder.Property(c => c.DocenteId).IsRequired();
            builder.Property(c => c.Status).IsRequired();


            builder.HasOne(c => c.Ficha)
              .WithMany(c => c.RelacionamentoDocenteFichas)
              .HasForeignKey(c => c.FichaId);

            builder.HasOne(c => c.Docente)
              .WithMany(c => c.RelacionamentoDocenteFichas)
              .HasForeignKey(c => c.DocenteId);

        }
    }
}
