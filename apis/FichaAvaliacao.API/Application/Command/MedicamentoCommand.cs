using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para Medicamento
    /// </summary>
    public class AddMedicamentoCommand : CommandAdd
    {
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string Nome { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new MedicamentoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Medicamento
        /// </summary>
        public class MedicamentoValidation : AbstractValidator<AddMedicamentoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Medicamento
            /// </summary>
            public MedicamentoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para Medicamento
    /// </summary>
    public class UpdMedicamentoCommand : CommandUpd
    {
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string Nome { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new MedicamentoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Medicamento
        /// </summary>
        public class MedicamentoValidation : AbstractValidator<UpdMedicamentoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Medicamento
            /// </summary>
            public MedicamentoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Descricao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Nome)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
