using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para Estado
    /// </summary>
    public class AddEstadoCommand : CommandAdd
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EstadoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Estado
        /// </summary>
        public class EstadoValidation : AbstractValidator<AddEstadoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Estado
            /// </summary>
            public EstadoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Sigla)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(2).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");


              

            }
        }
    }

    /// <summary>
    /// Classe Command para Estado
    /// </summary>
    public class UpdEstadoCommand : CommandUpd
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EstadoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Estado
        /// </summary>
        public class EstadoValidation : AbstractValidator<UpdEstadoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Estado
            /// </summary>
            public EstadoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Sigla)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(2).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");




            }
        }
    }
}
