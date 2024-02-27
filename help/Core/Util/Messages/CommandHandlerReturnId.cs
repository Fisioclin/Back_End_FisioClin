using Core.Util.Data;
using FluentValidation.Results;

namespace Posto.Core.Messages
{
    public abstract class CommandHandlerReturnId
    {
        protected ValidationResult ValidationResult;

        protected CommandHandlerReturnId()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new FluentValidation.Results.ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AdicionarErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
