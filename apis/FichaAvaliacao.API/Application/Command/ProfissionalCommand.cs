using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para Profissional
    /// </summary>
    public class AddProfissionalCommand : CommandAdd
    {
        public string Profissao { get;  set; }
        public string NumeroRegistro { get;  set; }
        public int CadastroId { get;  set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ProfissionalValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Profissional
        /// </summary>
        public class ProfissionalValidation : AbstractValidator<AddProfissionalCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Profissional
            /// </summary>
            public ProfissionalValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(b => b.CadastroId)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que 0");

                RuleFor(c => c.Profissao)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");
            }
        }
    }

    /// <summary>
    /// Classe Command para Profissional
    /// </summary>
    public class UpdProfissionalCommand : CommandUpd
    {
        public string Profissao { get; set; }
        public string NumeroRegistro { get; set; }
        public int CadastroId { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ProfissionalValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Profissional
        /// </summary>
        public class ProfissionalValidation : AbstractValidator<UpdProfissionalCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Profissional
            /// </summary>
            public ProfissionalValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(b => b.CadastroId)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que 0");

                RuleFor(c => c.Profissao)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");
            }
        }
    }
}
