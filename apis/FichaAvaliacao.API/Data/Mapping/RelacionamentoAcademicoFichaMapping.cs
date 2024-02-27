using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de RelacionamentoAcademicoFicha
    /// </summary>
    public class RelacionamentoAcademicoFichaMapping : IEntityTypeConfiguration<RelacionamentoAcademicoFicha>
    {
        public void Configure(EntityTypeBuilder<RelacionamentoAcademicoFicha> builder)
        {
            //Nome tabela 
            builder.ToTable("RelacionamentoAcademicoFicha");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.GuidId).IsRequired();
            builder.Property(c => c.DataLancamento).IsRequired();
            builder.Property(c => c.DataAtualizacao).IsRequired();
            builder.Property(c => c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioCriacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioAtualizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.FichaId).IsRequired();
            builder.Property(c => c.AcademicoId).IsRequired();
            builder.Property(c => c.Status).IsRequired();


            builder.HasOne(c => c.Ficha)
              .WithMany(c => c.RelacionamentoAcademicoFichas)
              .HasForeignKey(c => c.FichaId)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Academico)
              .WithMany(c => c.RelacionamentoAcademicoFichas)
              .HasForeignKey(c => c.AcademicoId)
              .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
