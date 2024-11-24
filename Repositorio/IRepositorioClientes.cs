using Floreria.Models;

namespace Floreria.Repositorio
{
    public interface IRepositorioClientes
    {
        Task<List<Cliente>> GetAll();
        Task<Cliente?> Get(int Id);
        Task<Cliente> Add(Cliente cliente);
        Task Update(int Id, Cliente cliente);
        Task Delete(int Id);
    }
}

