using Microsoft.EntityFrameworkCore;

namespace Floreria.Models
{
    public class ContexP : DbContext
    {
        public ContexP(DbContextOptions<ContexP> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}

