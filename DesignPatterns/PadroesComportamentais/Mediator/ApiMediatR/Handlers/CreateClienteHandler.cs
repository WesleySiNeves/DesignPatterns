using ApiMediatR.Model;
using ApiMediatR.Repositories;
using ApiMediatR.Services;
using MediatR;

namespace ApiMediatR.Handlers
{
    public class CreateClienteHandler : IRequestHandler<CreateClienteRequest, Guid>
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IValidationService _validationService;


        public CreateClienteHandler(IValidationService validationService, IClienteRepository clienteRepository)
        {
            _validationService = validationService;
            _clienteRepository = clienteRepository;




        }
        public async Task<Guid> Handle(CreateClienteRequest request, CancellationToken cancellationToken)
        {
            _validationService.Validate<Cliente>(request.Cliente);

            return await _clienteRepository.CreateCliente(request.Cliente);


        }
    }
}
