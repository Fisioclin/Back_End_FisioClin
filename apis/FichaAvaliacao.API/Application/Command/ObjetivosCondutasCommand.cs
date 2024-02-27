using Core.Util.Application;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para ObjetivosCondutas
    /// </summary>
    public class AddObjetivosCondutasCommand : CommandAdd
    {
        public string DiagnosticoTerapeutico { get;  set; }
        public string ObjetivosTratamento { get;  set; }
        public string CondutaFisioterapeutica { get;  set; }
        public AddProfissionalCommand? Profissional { get;  set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ObjetivosCondutasValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da ObjetivosCondutas
        /// </summary>
        public class ObjetivosCondutasValidation : AbstractValidator<AddObjetivosCondutasCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ObjetivosCondutas
            /// </summary>
            public ObjetivosCondutasValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DiagnosticoTerapeutico)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.ObjetivosTratamento)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CondutaFisioterapeutica)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(1000).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para ObjetivosCondutas
    /// </summary>
    public class UpdObjetivosCondutasCommand : CommandUpd
    {
        public string DiagnosticoTerapeutico { get; set; }
        public string ObjetivosTratamento { get; set; }
        public string CondutaFisioterapeutica { get; set; }
        public UpdProfissionalCommand? Profissional { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ObjetivosCondutasValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da ObjetivosCondutas
        /// </summary>
        public class ObjetivosCondutasValidation : AbstractValidator<UpdObjetivosCondutasCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ObjetivosCondutas
            /// </summary>
            public ObjetivosCondutasValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DiagnosticoTerapeutico)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.ObjetivosTratamento)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CondutaFisioterapeutica)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(1000).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
