using Floreria.Models;

namespace Floreria.Repositorio
{
    public interface IRepositorioProductos
    {
        Task<List<Producto>> GetAll();
        Task<Producto?> Get(int Id);
        Task<Producto> AddP(Producto producto);
        Task UpdateP(int Id, Producto producto);
        Task DeleteP(int Id);
    }
}

