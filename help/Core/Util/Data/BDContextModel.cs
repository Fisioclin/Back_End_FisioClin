
using Core.Util.Domain;
using Core.Util.Mediator;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Core.Util.Data
{
    public class BDContextModel : DbContext, IUnitOfWork
    {
        public readonly IMediatorHandler _mediatorHandler;
        public readonly IConfiguration _configuration;
        /// <summary>
        /// Método do construtor do contexto com parâmetro
        /// </summary>
        /// <param name="options">Parâmetro de opções do contexto</param>
        /// <param name="mediatorHandler">Parâmetro de opções do contexto</param>
        /// <param name="configuration">Parâmetro de configuração da aplicação</param>
        public BDContextModel(DbContextOptions options,
             IMediatorHandler mediatorHandler,
             IConfiguration configuration
            ) : base(options)

        {
            _configuration = configuration;
            _mediatorHandler = mediatorHandler;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
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
