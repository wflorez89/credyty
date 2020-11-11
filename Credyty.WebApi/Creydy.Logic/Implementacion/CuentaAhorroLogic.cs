using Credyty.CustomTypes;
using Credyty.Logic.Interfaces;
using Credyty.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;

namespace Credyty.Logic.Implementacion
{
    public class CuentaAhorroLogic : ICuentaAhorroLogic
    {

        private ICuentaAhorroRepository _cuentaAhorroRepository;
        private ILogger<CuentaAhorroLogic> _logger;

        public CuentaAhorroLogic(
            ICuentaAhorroRepository cuentaAhorroRepository,
            ILogger<CuentaAhorroLogic> logger
            )
        {
            _cuentaAhorroRepository = cuentaAhorroRepository;
            _logger = logger;
        }

        public CuentaAhorroModel Add(CuentaAhorroModel c)
        {
            try
            {
                var cuenta = GetCuenta();
                c.NumeroCuenta = cuenta;
                return _cuentaAhorroRepository.Add(c);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        public void CancelarCuenta(int id)
        {
            try
            {
                _cuentaAhorroRepository.CancelarCuenta(id);
            }
            catch (System.Exception e)
            {
                _logger.LogError(e.ToString());
                throw;
            }
        }

        private  string GetCuenta() 
        {
            var cuenta = string.Empty;
            var random = new Random();
            for (int i = 0; i < 12; i++)
            {
                var numero = random.Next(0, 9);
                cuenta = $"{cuenta}{numero}";
            }

            return cuenta;
        }
    }
}
