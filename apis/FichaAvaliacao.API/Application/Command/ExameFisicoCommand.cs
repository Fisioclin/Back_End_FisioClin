using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para ExameFisico
    /// </summary>
    public class AddExameFisicoCommand : CommandAdd
    {
        public string Inspecao { get; set; }
        public string Palpacao { get; set; }
        public AddADMCommand? ADM { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ExameFisicoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Avaliacao
        /// </summary>
        public class ExameFisicoValidation : AbstractValidator<AddExameFisicoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ExameFisico
            /// </summary>
            public ExameFisicoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Inspecao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Palpacao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para ExameFisico
    /// </summary>
    public class UpdExameFisicoCommand : CommandUpd
    {
        public string Inspecao { get; set; }
        public string Palpacao { get; set; }
        public UpdADMCommand? ADM { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ExameFisicoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Avaliacao
        /// </summary>
        public class ExameFisicoValidation : AbstractValidator<UpdExameFisicoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ExameFisico
            /// </summary>
            public ExameFisicoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Inspecao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Palpacao)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(500).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
