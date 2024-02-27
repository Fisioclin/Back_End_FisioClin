using AutoMapper;
using Core.Util.Auth;
using Core.Util.Controllers;
using Core.Util.Mediator;
using FichaAvaliacao.API.Application.Command;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controller
{
    [Route("api/[controller]")]
    public class CadastroController : ControllerGeral<Cadastro, AddCadastroCommand, UpdCadastroCommand, CadastroDTO>
    {
        private readonly ICadastroRepository _cadastroRepositorie;
        private readonly AuthenticatedUser _authenticatedUser;

        public CadastroController(
            ICadastroRepository cadastroRepositorie, 
            IMapper mapper,
            IMediatorHandler mediator,
        AuthenticatedUser authenticatedUser
            ) : base(cadastroRepositorie, mapper, mediator,authenticatedUser)
        {
            _cadastroRepositorie = cadastroRepositorie;
            _authenticatedUser= authenticatedUser;
        }
    }
}
