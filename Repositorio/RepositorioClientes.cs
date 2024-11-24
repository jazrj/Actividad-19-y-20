using Floreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Floreria.Repositorio
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly Contex _context;

        public RepositorioClientes(Contex context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int Id)
        {
            var cliente = await _context.Clientes.FindAsync(Id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> Get(int Id)
        {
            return await _context.Clientes.FindAsync(Id);
        }

        public async Task<List<Cliente>> GetAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task Update(int Id, Cliente cliente)
        {
            var clienteActual = await _context.Clientes.FindAsync(Id);
            if (clienteActual != null)
            {
                clienteActual.Nombre = cliente.Nombre;
                clienteActual.Apellido = cliente.Apellido;
                clienteActual.Direccion = cliente.Direccion;
                clienteActual.Correo = cliente.Correo;
                clienteActual.Telefono = cliente.Telefono;

                await _context.SaveChangesAsync();
            }
        }
    }
}
