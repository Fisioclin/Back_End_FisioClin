using FichaAvaliacao.API.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FichaAvaliacao.API.Data.Mapping
{
    /// <summary>
    /// Mapping de RelacionamentoCadastroProfissao
    /// </summary>
    public class RelacionamentoCadastroProfissaoMapping : IEntityTypeConfiguration<RelacionamentoCadastroProfissao>
    {
        public void Configure(EntityTypeBuilder<RelacionamentoCadastroProfissao> builder)
        {
            //Nome tabela 
            builder.ToTable("RelacionamentoCadastroRelacionamentoCadastroProfissao");

            builder.HasKey(c=>c.Id);

            builder.Property(c=>c.ProfissaoId).IsRequired();
            builder.Property(c=>c.CadastroId).IsRequired();

            builder.HasOne(c => c.Profissao)
                .WithMany(c => c.RelacionamentoCadastroProfissaos)
                .HasForeignKey(c => c.ProfissaoId);

            builder.HasOne(c => c.Cadastro)
                .WithMany(c => c.RelacionamentoCadastroProfissaos)
                .HasForeignKey(c => c.CadastroId);
        }
    }
}
