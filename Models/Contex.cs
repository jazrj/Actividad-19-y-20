using Microsoft.EntityFrameworkCore;

namespace Floreria.Models
{
    public class Contex : DbContext
    {
        public Contex(DbContextOptions<Contex> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}

