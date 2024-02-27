using Posto.Core.Messages;
using FluentValidation.Results;
using Core.Util.Application;

namespace Core.Util.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;

        Task<ValidationResult> EnviarComandoAdd<T>(T comando) where T : CommandAdd;
        Task<ValidationResult> EnviarComandoUpd<T>(T comando) where T : CommandUpd;
    }
 }