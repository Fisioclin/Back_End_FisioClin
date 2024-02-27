using Core.Util.Auth;
using Core.Util.Domain;
using Core.Util.Mediator;
using FichaAvaliacao.API.Application.Command;
using FichaAvaliacao.API.Data.Context;
using FichaAvaliacao.API.Data.Repositories;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;
using MediatR;

namespace FichaAvaliacao.API.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependenciesFichaAvaliacao(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            //services.AddScoped<IAnamneseRepository, AnamneseRepository>();
            services.AddScoped<ICadastroRepository, CadastroRepository>();

            //services.AddScoped<IAntecedentesPessoaisRepository, AntecedentesPessoaisRepository>();
            //services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            //services.AddScoped<IEstadoRepository, EstadoRepository>();
            //services.AddScoped<IEvolucaoRepository, EvolucaoRepository>();
            //services.AddScoped<IFichaRepository, FichaRepository>();
            //services.AddScoped<IMedicamentoRepository, MedicamentoRepository>();
            //services.AddScoped<IMusculoRepository, MusculoRepository>();
            //services.AddScoped<IObjetivosCondutasRepository, ObjetivosCondutasRepository>();
            //services.AddScoped<IPaisRepository, PaisRepository>();
            //services.AddScoped<IProfissaoRepository, ProfissaoRepository>();
            //services.AddScoped<IProfissionalRepository, ProfissionalRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<AuthenticatedUser>();
            services.AddScoped<BDContext>();
            services.AddSingleton<BaseModel>();

            return services;
        }
    }
}
