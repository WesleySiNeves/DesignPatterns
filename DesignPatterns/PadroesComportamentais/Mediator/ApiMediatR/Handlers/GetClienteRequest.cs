using ApiMediatR.Model;
using MediatR;

namespace ApiMediatR.Handlers
{
    public class GetClienteRequest : IRequest<Cliente>
    {
        public Guid Id { get; set; }
    }
}
