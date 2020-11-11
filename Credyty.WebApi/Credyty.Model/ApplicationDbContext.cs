using Credyty.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaAhorro> CuentasAhorros { get; set; }
        public DbSet<MovimientoCuenta> MovmienetosCuentas { get; set; }

    }
}
