using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Docente
    /// </summary>
    public class DocenteMapping : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)
        {
            //Nome tabela 
            builder.ToTable("Docente");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.GuidId).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioCriacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.NomeUsuarioAtualizacao).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.NumeroRegistro).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.CadastroId).IsRequired();
            builder.Property(c => c.Status).IsRequired();

            builder.HasOne(c => c.Cadastro)
                .WithOne(c => c.Docente)
                .HasForeignKey<Docente>(c => c.CadastroId);

        }
    }
}
