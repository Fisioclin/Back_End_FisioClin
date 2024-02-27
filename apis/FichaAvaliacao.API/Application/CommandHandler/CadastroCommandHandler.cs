using FichaAvaliacao.API.Application.Command;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;
using FluentValidation.Results;
using MediatR;
using Posto.Core.Messages;

namespace FichaAvaliacao.API.Application.CommandHandler
{
    /// <summary>
    /// Classe Command Handler 
    /// </summary>
    public class CadastroCommandHandler : CommandHandlerReturnId,
         IRequestHandler<AddCadastroCommand, ValidationResult>,
         IRequestHandler<UpdCadastroCommand, ValidationResult>
    {
        #region Atributos e Construtor
        private readonly ICadastroRepository _cadastroRepository;


        public CadastroCommandHandler(
            ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }
        #endregion

        public async Task<ValidationResult> Handle(AddCadastroCommand request, CancellationToken cancellationToken)
        {
            //Valida os Commands
            if (!request.EhValido())
            {
                return request.ValidationResult;
            }

            var cadastro = new Cadastro(DateTime.Now, DateTime.Now,request.UsuarioId,
                request.UsuarioId, request.CompanyId,request.Nome, request.Cor, request.Sexo, request.DataNascimento,
                request.Profissao,request.Naturalidade, null,null,request.CPF,request.RG,
                request.Email,request.Telefone, request.Empresa);
            //insere no repositorio
            var guid = await _cadastroRepository.CreateAsync(cadastro);

            //Persisti os dados
            var result = await PersistirDados(_cadastroRepository.UnitOfWork);

            //atualiza o id para retorno
            //result.TransactionId = guid;

            //retorna result com validacoes
            return result;
        }

        public async Task<ValidationResult> Handle(UpdCadastroCommand request, CancellationToken cancellationToken)
        {
            //Valida os Commands
            if (!request.EhValido())
            {
                return request.ValidationResult;
            }

            var cadastro = await _cadastroRepository.GetAsync(request.Id, request.CompanyId);

            if (cadastro == null)

            {
                AdicionarErro($"Não existe cadastro com Id : {request.Id}");
                return ValidationResult;
            }

            cadastro.setCor(request.Cor);

            //atualiza repositorio
            _cadastroRepository.UpdateAsync(cadastro);

            //Persisti os dados
            return await PersistirDados(_cadastroRepository.UnitOfWork);
        }
    }
}
