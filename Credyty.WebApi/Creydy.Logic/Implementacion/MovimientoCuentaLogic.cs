using Credyty.CustomTypes;
using Credyty.Logic.Interfaces;
using Credyty.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace Credyty.Logic.Implementacion
{
    public class MovimientoCuentaLogic : IMovimientoCuentaLogic
    {

        private IMovimientoCuentaRepository _movimientoCuentaRepository;
        private ILogger<MovimientoCuentaLogic> _logger;

        public MovimientoCuentaLogic(
            IMovimientoCuentaRepository movimientoCuentaRepository,
            ILogger<MovimientoCuentaLogic> logger
            )
        {
            _movimientoCuentaRepository = movimientoCuentaRepository;
            _logger = logger;
        }


        public void Add(MovimientoCuentaModel c)
        {
            try
            {
                if (c.Valor < 0)
                {
                    var saldo = GetSaldoCuentaId(c.CuentaAhorroId);
                    if (saldo < Math.Abs(c.Valor) )
                    {
                        throw new System.Exception("Saldo insuficiente");
                    }
                }
                _movimientoCuentaRepository.Add(c);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        private decimal GetSaldoCuentaId(int cuentaid)
        {
            try
            {
                return _movimientoCuentaRepository.GetSaldoCuentaId(cuentaid);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }
    }
}
