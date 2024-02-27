using Core.Util.Application;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{

    /// <summary>
    /// Classe Command para  Ficha
    /// </summary>
    public class AddFichaCommand : CommandAdd
    {
        public DateTime DataAvaliacao { get;  set; }
        public AddAnamneseCommand? Anamnese { get;  set; }
        public AddExameFisicoCommand? ExameFisico { get;  set; }
        public AddObjetivosCondutasCommand? ObjetivosConduta { get;  set; }
        public List<AddEvolucaoCommand>? Evolucaos { get;  set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new FichaValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Ficha
        /// </summary>
        public class FichaValidation : AbstractValidator<AddFichaCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Ficha
            /// </summary>
            public FichaValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DataAvaliacao)
                    .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("O campo {PropertyName} deve ser informado.");

            }
        }
    }

    /// <summary>
    /// Classe Command para  Ficha
    /// </summary>
    public class UpdFichaCommand : CommandUpd
    {
        public DateTime DataAvaliacao { get; set; }
        public UpdAnamneseCommand? Anamnese { get; set; }
        public UpdExameFisicoCommand? ExameFisico { get; set; }
        public UpdObjetivosCondutasCommand? ObjetivosConduta { get; set; }
        public List<UpdEvolucaoCommand>? Evolucaos { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new FichaValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Ficha
        /// </summary>
        public class FichaValidation : AbstractValidator<UpdFichaCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Ficha
            /// </summary>
            public FichaValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.DataAvaliacao)
                    .GreaterThan(new DateTime(1900, 1, 1)).WithMessage("O campo {PropertyName} deve ser informado.");

            }
        }
    }

    /// <summary>
    /// Classe Command para Cancelar Ficha
    /// </summary>
    public class CancelarFichaCommand : CommandUpd
    {
        public int Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new FichaValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Ficha
        /// </summary>
        public class FichaValidation : AbstractValidator<CancelarFichaCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Ficha
            /// </summary>
            public FichaValidation()
            {
                RuleFor(b => b.Id)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(c => c.NomeUsuario)
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
