using ApiMediatR.Model;
using MediatR;

namespace ApiMediatR.Handlers
{
    public class CreateClienteRequest : IRequest<Guid>
    {
        public Cliente Cliente { get; set; }
    }
}
