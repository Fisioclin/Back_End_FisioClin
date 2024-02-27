using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;

namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para Musculo
    /// </summary>
    public class AddMusculoCommand : CommandAdd
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new MusculoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Musculo
        /// </summary>
        public class MusculoValidation : AbstractValidator<AddMusculoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Musculo
            /// </summary>
            public MusculoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado");

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para Musculo
    /// </summary>
    public class UpdMusculoCommand : CommandUpd
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new MusculoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Musculo
        /// </summary>
        public class MusculoValidation : AbstractValidator<UpdMusculoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Musculo
            /// </summary>
            public MusculoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado");

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
