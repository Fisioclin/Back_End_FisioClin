using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Cadastro
    /// </summary>
    public class CadastroMapping : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            //Nome tabela 
            builder.ToTable("Cadastro");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();
            builder.Property(c => c.DataLancamento).IsRequired();
            builder.Property(c => c.DataAtualizacao).IsRequired();
            builder.Property(c => c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.CPF).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.RG).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Profissao).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.Empresa).HasColumnType("varchar(100)").IsRequired();
            builder.Property(c => c.DataNascimento).IsRequired();
            builder.Property(c => c.Naturalidade).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.Telefone).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Status).IsRequired();

        }
    }
}
