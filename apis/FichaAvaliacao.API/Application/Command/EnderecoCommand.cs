using Core.Util.Application;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;

namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para Endereco
    /// </summary>
    public class AddEnderecoCommand : CommandAdd
    {
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EnderecoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Endereco
        /// </summary>
        public class EnderecoValidation : AbstractValidator<AddEnderecoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Endereco
            /// </summary>
            public EnderecoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Cidade)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Logradouro)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(150).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Numero)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Bairro)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Cep)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para Endereco
    /// </summary>
    public class UpdEnderecoCommand : CommandUpd
    {
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EnderecoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Endereco
        /// </summary>
        public class EnderecoValidation : AbstractValidator<UpdEnderecoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Endereco
            /// </summary>
            public EnderecoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.Cidade)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Logradouro)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(150).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Numero)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Bairro)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(50).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Cep)
                 .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                 .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                 .MaximumLength(20).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
