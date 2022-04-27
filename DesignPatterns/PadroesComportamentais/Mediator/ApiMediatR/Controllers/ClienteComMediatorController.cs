using ApiMediatR.Handlers;
using ApiMediatR.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteComMediatorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClienteComMediatorController(IMediator mediator)
        {
            this._mediator = mediator;
                
        }

        [HttpGet("get-cliente/{Id:guid}")]
        public async Task<Cliente> GetCliente(Guid Id)
        {



            return await _mediator.Send(new GetClienteRequest { Id = Id });


        }


        [HttpPost("create-cliente")]
        public async Task<Guid> CreateCliente([FromBody] Cliente cliente)
        {

            return await _mediator.Send(new CreateClienteRequest { Cliente = cliente });


        }
    }
}
