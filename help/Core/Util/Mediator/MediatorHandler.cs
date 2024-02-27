using Core.Util.Application;
using FluentValidation.Results;
using MediatR;
using Posto.Core.Messages;

namespace Core.Util.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<ValidationResult> EnviarComandoAdd<T>(T comando) where T : CommandAdd
        {
            return await _mediator.Send(comando);
        }

        public async Task<ValidationResult> EnviarComandoUpd<T>(T comando) where T : CommandUpd
        {
            return await _mediator.Send(comando);
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
