using Floreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Floreria.Repositorio
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly ContexP _contextp;

        public RepositorioProductos(ContexP contextp)
        {
            _contextp = contextp;
        }

        public async Task<Producto> AddP(Producto producto)
        {
            await _contextp.Productos.AddAsync(producto);
            await _contextp.SaveChangesAsync();
            return producto;
        }


        public async Task DeleteP(int Id)
        {
            var producto = await _contextp.Productos.FindAsync(Id);
            if (producto != null)
            {
                _contextp.Productos.Remove(producto);
                await _contextp.SaveChangesAsync();
            }
        }

        public async Task<Producto?> Get(int Id)
        {
            return await _contextp.Productos.FindAsync(Id);
        }

        public async Task<List<Producto>> GetAll()
        {
            return await _contextp.Productos.ToListAsync();
        }

        public async Task UpdateP(int Id, Producto producto)
        {
            var productoActual = await _contextp.Productos.FindAsync(Id);
            if (productoActual != null)
            {
                productoActual.NombreProducto = producto.NombreProducto;
                productoActual.TipoProducto = producto.TipoProducto;
                productoActual.Descripcion = producto.Descripcion;
                productoActual.Precio = producto.Precio;

                await _contextp.SaveChangesAsync();
            }
        }
    }
}
