using Core.Util.Application;
using FluentValidation;
using FluentValidation.Results;


namespace FichaAvaliacao.API.Application.Command
{
    /// <summary>
    /// Classe Command para Anamnese
    /// </summary>
    public class AddAnamneseCommand : CommandAdd
    {
        public string DiagnosticoClinico { get;  set; }
        public AddProfissionalCommand? Profissional { get;  set; }
        public string CID10 { get;  set; }
        public double Peso { get;  set; }
        public double Altura { get;  set; }
        public double IMC { get;  set; }
        public string QueixaPrincipal { get;  set; }
        public string HDA { get;  set; }
        public string MedicoResponsavel { get; set; }
        public List<AddAntecedentesFamiliaresCommand>? AntecedentesFamiliares { get;  set; }
        public List<AddAntecedentesPessoaisCommand>? AntecedentesPessoais { get;  set; }
        public List<AddMedicamentoCommand>? Medicamentos { get;  set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new AnamneseValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Anamnese
        /// </summary>
        public class AnamneseValidation : AbstractValidator<AddAnamneseCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Anamnese
            /// </summary>
            public AnamneseValidation()
            {


                RuleFor(c => c.DiagnosticoClinico)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CID10)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(b => b.Peso)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(b => b.Altura)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(b => b.IMC)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado");

            }
        }
    }

    /// <summary>
    /// Classe Command para Anamnese
    /// </summary>
    public class UpdAnamneseCommand : CommandUpd
    {
        public string DiagnosticoClinico { get; set; }
        public UpdProfissionalCommand? Profissional { get; set; }
        public string CID10 { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
        public string QueixaPrincipal { get; set; }
        public string HDA { get; set; }
        public string MedicoResponsavel { get; set; }
        public List<UpdAntecedentesFamiliaresCommand>? AntecedentesFamiliares { get; set; }
        public List<UpdAntecedentesPessoaisCommand>? AntecedentesPessoais { get; set; }
        public List<UpdMedicamentoCommand>? Medicamentos { get; set; }
        /// <summary>
        /// Metodo chamado para validar
        /// </summary>
        /// <returns></returns>
        public override bool EhValido()
        {
            var result = new AnamneseValidation().Validate(this);
            this.ValidationResult = new ValidationResult(result.Errors);
            return ValidationResult.IsValid;
        }

        /// <summary>
        /// Classe de validação da Anamnese
        /// </summary>
        public class AnamneseValidation : AbstractValidator<UpdAnamneseCommand>
        {
            /// <summary>
            /// Contrutor para validacao de Anamnese
            /// </summary>
            public AnamneseValidation()
            {


                RuleFor(c => c.DiagnosticoClinico)
                   .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                   .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                   .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(c => c.CID10)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado")
                  .NotEmpty().WithMessage("o campo {PropertyName} deve ser informado")
                  .MaximumLength(100).WithMessage("o campo {PropertyName} deve possuir no máximo {MaxLength} caracteres");

                RuleFor(b => b.Peso)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(b => b.Altura)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(b => b.IMC)
                   .NotNull().WithMessage("{PropertyName} não pode ser nulo")
                   .GreaterThan(0).WithMessage("{PropertyName} deve ser maior que {ComparisonValue}");

                RuleFor(c => c.UsuarioId)
                  .NotNull().WithMessage("o campo {PropertyName} deve ser informado");

            }
        }
    }
}
