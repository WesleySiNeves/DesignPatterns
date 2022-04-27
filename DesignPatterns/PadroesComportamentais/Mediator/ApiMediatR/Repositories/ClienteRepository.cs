using ApiMediatR.Model;

namespace ApiMediatR.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private static   List<Cliente> _clienteList;

        public ClienteRepository()
        {
            if (_clienteList == null)
            {
                _clienteList = new List<Cliente>();
                _clienteList.Add(new Cliente { Id = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), Name = "Wesley" });
                _clienteList.Add(new Cliente { Id = Guid.NewGuid(), Name = "João" });
            }
            
           
        }

        public async Task<Cliente> Get(Guid id)
        {

            
            return  _clienteList?.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Guid> CreateCliente(Cliente cliente)
        {

            if (_clienteList.Exists(cli => cli.Name == cliente.Name))
            {
                return Guid.Empty;

            }

            _clienteList.Add(cliente);

            return cliente.Id;

        }

        public async Task<List<Cliente>> GetAll()
        {
            return _clienteList;
        }
    }
}
