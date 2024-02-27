using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para TiposAntecedentesPessoais
    /// </summary>
    public class AddTiposAntecedentesPessoaisCommand : CommandAdd
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new TiposAntecedentesPessoaisValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da TiposAntecedentesPessoais
        /// </summary>
        public class TiposAntecedentesPessoaisValidation : AbstractValidator<AddTiposAntecedentesPessoaisCommand>
        {
            /// <summary>
            /// Contrutor para validacao de TiposAntecedentesPessoais
            /// </summary>
            public TiposAntecedentesPessoaisValidation()
            {

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

            }
        }
    }

    /// <summary>
    /// Classe Command para TiposAntecedentesPessoais
    /// </summary>
    public class UpdTiposAntecedentesPessoaisCommand : CommandUpd
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new TiposAntecedentesPessoaisValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da TiposAntecedentesPessoais
        /// </summary>
        public class TiposAntecedentesPessoaisValidation : AbstractValidator<UpdTiposAntecedentesPessoaisCommand>
        {
            /// <summary>
            /// Contrutor para validacao de AntecedentesPessoais
            /// </summary>
            public TiposAntecedentesPessoaisValidation()
            {

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

            }
        }
    }
}
