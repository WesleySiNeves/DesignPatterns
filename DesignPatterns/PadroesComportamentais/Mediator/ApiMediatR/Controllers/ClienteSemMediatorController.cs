using ApiMediatR.Model;
using ApiMediatR.Repositories;
using ApiMediatR.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteSemMediatorController : ControllerBase
    {
        private   readonly IClienteRepository _clienteRepository;
        private readonly IValidationService _validationService;


        public ClienteSemMediatorController(IClienteRepository repository, IValidationService validation)
        {
            this._clienteRepository = repository;
            this._validationService = validation;


        }

        [HttpGet("get-cliente/{Id:guid}")]
        public async Task<Cliente> GetCliente(Guid Id)
        {

            _validationService.Validate<Guid>(Id);

            return await _clienteRepository.Get(Id);


        }

        [HttpGet("get-All")]
        public async Task<List<Cliente>> GetAll()
        {

            return await _clienteRepository.GetAll();


        }

        [HttpPost("create-cliente")]
        public async Task<Guid> CreateCliente([FromBody] Cliente cliente)
        {

            _validationService.Validate<Cliente>(cliente);

            var customer = new Cliente { Name = cliente.Name };


            return await _clienteRepository.CreateCliente(customer);


        }
    }
}
