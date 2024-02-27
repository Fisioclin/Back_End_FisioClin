using AutoMapper;
using Core.Util.Auth;
using Core.Util.Controllers;
using Core.Util.Mediator;
using FichaAvaliacao.API.Application.Command;
using FichaAvaliacao.API.Application.DTO;
using FichaAvaliacao.API.Domain.Interface;
using FichaAvaliacao.API.Domain.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.API.Controller
{
    [Route("api/[controller]")]
    public class AnamneseController : ControllerGeral<Anamnese, AddAnamneseCommand,UpdAnamneseCommand, AnamneseDTO>
    {
        private readonly IAnamneseRepository _anamneseRepositorie;
        private readonly AuthenticatedUser _authenticatedUser;

        public AnamneseController(IAnamneseRepository anamneseRepositorie, 
            IMapper mapper,
            AuthenticatedUser authenticatedUser,
            IMediatorHandler mediator
            ) : base(anamneseRepositorie, mapper, mediator, authenticatedUser)
        {
            _anamneseRepositorie = anamneseRepositorie;
            _authenticatedUser= authenticatedUser;
        }
    }
}
