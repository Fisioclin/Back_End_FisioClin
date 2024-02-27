using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de Endereco
    /// </summary>
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            //Nome tabela 
            builder.ToTable("Endereco");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.Id).IsRequired();
            builder.Property(c=>c.DataLancamento).IsRequired();
            builder.Property(c=>c.DataAtualizacao).IsRequired();
            builder.Property(c=>c.UsuarioCriacaoId).IsRequired();
            builder.Property(c => c.UsuarioAtualizacaoId).IsRequired();
            builder.Property(c => c.Cidade).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Logradouro).HasColumnType("varchar(150)").IsRequired();
            builder.Property(c => c.Numero).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Bairro).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Cep).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Pais).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Estado).HasColumnType("varchar(20)").IsRequired();
            builder.Property(c => c.Status).IsRequired();
        }
    }
}
