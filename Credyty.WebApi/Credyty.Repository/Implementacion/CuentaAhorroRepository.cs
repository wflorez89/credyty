using Catalog.Persistence.Database;
using Credyty.CustomTypes;
using Credyty.CustomTypes.Enumeraciones;
using Credyty.Entidades;
using Credyty.Repository.Interfaces;
using System;

namespace Credyty.Repository.Implementacion
{
    public class CuentaAhorroRepository : ICuentaAhorroRepository
    {
        private readonly ApplicationDbContext _context;
        public CuentaAhorroRepository(
            ApplicationDbContext context)
        {
            _context = context;
        }


        public CuentaAhorroModel Add(CuentaAhorroModel c)
        {
            var entity = new CuentaAhorro
            {
                ClienteId = c.ClienteId,
                NumeroCuenta = c.NumeroCuenta,
                FechaCreacion = DateTime.Now,
                Estado = (int)CuentaAhorroEstados.Activa
            };

            _context.CuentasAhorros.Add(entity);
            _context.SaveChanges();
            c.Id = entity.Id;
            return c;
        }


        public void CancelarCuenta(int id)
        {
            var entity = _context.CuentasAhorros.Find(id);
            entity.Estado = (int)CuentaAhorroEstados.Cancelada;

            _context.SaveChanges();
        }
    }
}
