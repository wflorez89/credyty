using Catalog.Persistence.Database;
using Credyty.CustomTypes;
using Credyty.Entidades;
using Credyty.Repository.Interfaces;
using System.Linq;

namespace Credyty.Repository.Implementacion
{
    public class MovimientoCuentaRepository: IMovimientoCuentaRepository
    {
        private readonly ApplicationDbContext _context;
        public MovimientoCuentaRepository(
            ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(MovimientoCuentaModel c)
        {
            var entity = new MovimientoCuenta
            {
                CuentaAhorroId = c.CuentaAhorroId,
                Valor = c.Valor
            };

            _context.MovmienetosCuentas.Add(entity);
            _context.SaveChanges();
        }


        public decimal GetSaldoCuentaId(int cuentaid)
        {
            var saldo  = _context.MovmienetosCuentas
                .Where(c => c.CuentaAhorroId == cuentaid).Sum(c => c.Valor);
            return saldo;
        }






    }
}
