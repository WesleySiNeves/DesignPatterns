using ApiMediatR.Model;
using ApiMediatR.Repositories;
using ApiMediatR.Services;
using MediatR;

namespace ApiMediatR.Handlers
{
    public class GetClienteHandler : IRequestHandler<GetClienteRequest,Cliente>
    {

        private readonly IClienteRepository _clienteRepository;
        private readonly IValidationService _validationService;


        public GetClienteHandler(IValidationService validationService, IClienteRepository clienteRepository)
        {
            _validationService = validationService;
            _clienteRepository = clienteRepository;

                    

                
        }
        public async Task<Cliente> Handle(GetClienteRequest request, CancellationToken cancellationToken)
        {
            _validationService.Validate<Guid>(request.Id);

            return await _clienteRepository.Get(request.Id);


        }
    }
}
