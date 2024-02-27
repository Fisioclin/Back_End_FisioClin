using Core.Util.Application;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;

namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para TesteForcaMuscular
    /// </summary>
    public class AddTesteForcaMuscularCommand : CommandAdd
    {
        public AddMusculoCommand Musculo { get; set; }
        public string Grau { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new TesteForcaMuscularValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da TesteForcaMuscular
        /// </summary>
        public class TesteForcaMuscularValidation : AbstractValidator<AddTesteForcaMuscularCommand>
        {
            /// <summary>
            /// Contrutor para validacao de TesteForcaMuscular
            /// </summary>
            public TesteForcaMuscularValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Grau)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para TesteForcaMuscular
    /// </summary>
    public class UpdTesteForcaMuscularCommand : CommandUpd
    {
        public UpdMusculoCommand Musculo { get; set; }
        public string Grau { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new TesteForcaMuscularValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da TesteForcaMuscular
        /// </summary>
        public class TesteForcaMuscularValidation : AbstractValidator<UpdTesteForcaMuscularCommand>
        {
            /// <summary>
            /// Contrutor para validacao de TesteForcaMuscular
            /// </summary>
            public TesteForcaMuscularValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Grau)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
