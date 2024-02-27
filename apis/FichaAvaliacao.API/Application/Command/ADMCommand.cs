using Core.Util.Application;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Enum;
using FluentValidation;
using FluentValidation.Results;

namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para ADM
    /// </summary>
    public class AddADMCommand : CommandAdd
    {
        public EnumEstado MSD { get;  set; }
        public EnumEstado MSE { get;  set; }
        public string GoniometriaMsdMse { get;  set; }
        public EnumEstado MID { get;  set; }
        public EnumEstado MIE { get;  set; }
        public string GoniometriaMidMie { get;  set; }
        public string Perimetria { get; set; }
        public EnumEstado Coluna { get;  set; }
        public string GoniometriaColuna { get;  set; }
        public string TestesEspeciais { get;  set; }
        public List<AddTesteForcaMuscularCommand>? TesteForcaMusculares { get;  set; }
        public AddAvaliacaoSubjetivaDorCommand? AvaliacaoSubjetivaDor { get;  set; }
        public string ExamesComplementares { get; set; }
        public int[]? EscalaAnalogicaDor { get;  set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ADMValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da ADM
        /// </summary>
        public class ADMValidation : AbstractValidator<AddADMCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ADM
            /// </summary>
            public ADMValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.MSD)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.MSE)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaMsdMse)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.MID)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.MIE)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaMidMie)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Coluna)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaColuna)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.TestesEspeciais)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }

    /// <summary>
    /// Classe Command para ADM
    /// </summary>
    public class UpdADMCommand : CommandUpd
    {
        public EnumEstado MSD { get; set; }
        public EnumEstado MSE { get; set; }
        public string GoniometriaMsdMse { get; set; }
        public EnumEstado MID { get; set; }
        public EnumEstado MIE { get; set; }
        public string GoniometriaMidMie { get; set; }
        public string Perimetria { get; set; }
        public EnumEstado Coluna { get; set; }
        public string GoniometriaColuna { get; set; }
        public string TestesEspeciais { get; set; }
        public List<UpdTesteForcaMuscularCommand>? TesteForcaMusculares { get; set; }
        public UpdAvaliacaoSubjetivaDorCommand? AvaliacaoSubjetivaDor { get; set; }
        public string ExamesComplementares { get; set; }
        public int[] EscalaAnalogicaDor { get; set; }

        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new ADMValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da ADM
        /// </summary>
        public class ADMValidation : AbstractValidator<UpdADMCommand>
        {
            /// <summary>
            /// Contrutor para validacao de ADM
            /// </summary>
            public ADMValidation()
            {

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEqual(Guid.Empty);

                RuleFor(c => c.MSD)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.MSE)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaMsdMse)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.MID)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.MIE)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaMidMie)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.Coluna)
                   .IsInEnum().WithMessage("o campo {PropertyName} deve pertencer ao Enum");

                RuleFor(c => c.GoniometriaColuna)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.TestesEspeciais)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

            }
        }
    }
}
