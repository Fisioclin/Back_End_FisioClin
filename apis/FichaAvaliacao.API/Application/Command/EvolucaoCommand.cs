using Core.Util.Application;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para Evolucao
    /// </summary>
    public class AddEvolucaoCommand : CommandAdd
    {
        public DateTime DataEvolucao { get;  set; }
        public string PressaoInicial { get;  set; }
        public string PressaoFinal { get;  set; }
        public string Observacao { get;  set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EvolucaoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Evolucao
        /// </summary>
        public class EvolucaoValidation : AbstractValidator<AddEvolucaoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Evolucao
            /// </summary>
            public EvolucaoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DataEvolucao)
                     .GreaterThan(new DateTime(1900, 1, 1))
                     .WithMessage("O campo {PropertyName} deve ser uma data válida");
            }
        }
    }

    /// <summary>
    /// Classe Command para Evolucao
    /// </summary>
    public class UpdEvolucaoCommand : CommandUpd
    {
        public DateTime DataEvolucao { get; set; }
        public string PressaoInicial { get; set; }
        public string PressaoFinal { get; set; }
        public string Observacao { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new EvolucaoValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Evolucao
        /// </summary>
        public class EvolucaoValidation : AbstractValidator<UpdEvolucaoCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Evolucao
            /// </summary>
            public EvolucaoValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DataEvolucao)
                     .GreaterThan(new DateTime(1900, 1, 1))
                     .WithMessage("O campo {PropertyName} deve ser uma data válida");
            }
        }
    }
}
