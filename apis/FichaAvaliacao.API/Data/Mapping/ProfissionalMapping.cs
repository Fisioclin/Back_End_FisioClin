using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Profissional
    /// </summary>
    public class ProfissionalMapping : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {
            //Nome tabela 
            builder.ToTable("Profissional");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            
            builder.Property(c => c.NumeroRegistro).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.CadastroId).IsRequired();
            builder.Property(c => c.Profissao).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
