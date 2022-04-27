using ApiMediatR.Model;

namespace ApiMediatR.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> GetAll();

        Task<Cliente> Get(Guid id);

        Task<Guid> CreateCliente(Cliente cliente);


    }
}
