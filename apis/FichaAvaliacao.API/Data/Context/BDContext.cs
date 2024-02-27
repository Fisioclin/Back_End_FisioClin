
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using FichaAvaliacao.API.Domain.Model;
using FichaAvaliacao.API.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Core.Util.Data;
using Core.Util.Mediator;
using Posto.Core.Messages;
using Core.Util.Domain;

namespace FichaAvaliacao.API.Data.Context
{
    public class BDContext : BDContextModel, IUnitOfWork
    {
        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Medicamento> Medicamentos { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Profissao> Profissaos{ get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Pais> Pais { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Estado> Estados { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Cadastro> Cadastros { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Profissional> Profissionals { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Anamnese> Anamneses{ get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<AntecedentesPessoais> AntecedentesPessoais { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<AvaliacaoSubjetivaDor> Avaliacaos { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<ObjetivosCondutas> ObjetivosCondutas{ get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Musculo> Musculos { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Ficha> Fichas { get; set; }

        /// <summary>
        /// Propriedade DbSet para criação da entidade
        /// </summary>
        public DbSet<Evolucao> Evolucaos { get; set; }
        /// <summary>
        /// Método do construtor do contexto com parâmetro
        /// </summary>
        /// <param name="options">Parâmetro de opções do contexto</param>
        /// <param name="mediatorHandler">Parâmetro de opções do contexto</param>
        /// <param name="configuration">Parâmetro de configuração da aplicação</param>
        public BDContext(DbContextOptions options,
            IConfiguration configuration,
             IMediatorHandler mediatorHandler
            ) : base(options, mediatorHandler, configuration)

        {
        }

        /// <summary>
        /// Método de configuração do contexto
        /// </summary>
        /// <param name="optionsBuilder">Parâmetro de opções de construção</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        /// <summary>
        /// Método de criação do contexto
        /// </summary>
        /// <param name="modelBuilder">Parâmetro do modelo de construção</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Event>();

            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new MedicamentoMapping());
            //modelBuilder.ApplyConfiguration(new PaisMapping());
            //modelBuilder.ApplyConfiguration(new EstadoMapping());
            //modelBuilder.ApplyConfiguration(new EnderecoMapping());
            //modelBuilder.ApplyConfiguration(new FichaMapping());
            //modelBuilder.ApplyConfiguration(new AnamneseMapping());
            modelBuilder.ApplyConfiguration(new CadastroMapping());
            //modelBuilder.ApplyConfiguration(new ProfissaoMapping());
            //modelBuilder.ApplyConfiguration(new ProfissionalMapping());
            //modelBuilder.ApplyConfiguration(new AntecedentesPessoaisMapping());
            //modelBuilder.ApplyConfiguration(new MusculoMapping());
            //modelBuilder.ApplyConfiguration(new TesteForcaMuscularMapping());
            //modelBuilder.ApplyConfiguration(new AvaliacaoSubjetivaDorMapping());
            //modelBuilder.ApplyConfiguration(new ADMMapping());
            //modelBuilder.ApplyConfiguration(new ObjetivosCondutasMapping());
            //modelBuilder.ApplyConfiguration(new EvolucaoMapping());
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            if (sucesso) await _mediatorHandler.PublicarEventos(this);

            return sucesso;

        }
    }

    /// <summary>
    /// Classe Statica de Extensão do Mediantes
    /// </summary>
    public static class MediatorExtension
    {
        /// <summary>
        /// Metodo que publica os eventos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mediator"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        public static async Task PublicarEventos<T>(this IMediatorHandler mediator, T ctx) where T : DbContext
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<BaseModel>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.Notificacoes)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.LimparEventos());

            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublicarEvento(domainEvent);
                });

            await Task.WhenAll(tasks);
        }
    }
}
