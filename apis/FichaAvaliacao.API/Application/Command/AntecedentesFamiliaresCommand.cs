using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para AntecedentesFamiliares
    /// </summary>
    public class AddAntecedentesFamiliaresCommand : CommandAdd
    {
        public string Nome { get;  set; }
        public string Observacao { get;  set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new AntecedentesFamiliaresValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da AntecedentesFamiliares
        /// </summary>
        public class AntecedentesFamiliaresValidation : AbstractValidator<AddAntecedentesFamiliaresCommand>
        {
            /// <summary>
            /// Contrutor para validacao de AntecedentesFamiliares
            /// </summary>
            public AntecedentesFamiliaresValidation()
            {
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
    /// Classe Command para AntecedentesFamiliares
    /// </summary>
    public class UpdAntecedentesFamiliaresCommand : CommandUpd
    {
        public string Nome { get; set; }
        public string Observacao { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new AntecedentesFamiliaresValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da AntecedentesFamiliares
        /// </summary>
        public class AntecedentesFamiliaresValidation : AbstractValidator<UpdAntecedentesFamiliaresCommand>
        {
            /// <summary>
            /// Contrutor para validacao de AntecedentesFamiliares
            /// </summary>
            public AntecedentesFamiliaresValidation()
            {
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
