using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de ADM
    /// </summary>
    public class ADMMapping : IEntityTypeConfiguration<ADM>
    {
        public void Configure(EntityTypeBuilder<ADM> builder)
        {
            //Nome tabela 
            builder.ToTable("ADM");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.MSD).IsRequired();
            builder.Property(c => c.MSE).IsRequired();
            builder.Property(c => c.GoniometriaMsdMse).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.MID).IsRequired();
            builder.Property(c => c.MIE).IsRequired();
            builder.Property(c => c.GoniometriaMidMie).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Coluna).IsRequired();
            builder.Property(c => c.GoniometriaColuna).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.TestesEspeciais).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Status).IsRequired();

        }
    }
}
