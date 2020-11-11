using Credyty.CustomTypes;
using Credyty.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Credyty.WebApi.Controllers
{
    [Route("cuentaahorro")]
    [ApiController]
    public class CuentaAhorroController : ControllerBase
    {
        private readonly ICuentaAhorroLogic _cuentaAhorroLogic;
        private readonly ILogger<CuentaAhorroController> _logger;
        public CuentaAhorroController(
            ILogger<CuentaAhorroController> logger,
            ICuentaAhorroLogic cuentaAhorroLogic)
        {
            _logger = logger;
            _cuentaAhorroLogic = cuentaAhorroLogic;
        }

        [HttpPost]
        public CuentaAhorroModel Add(CuentaAhorroModel c)
        {
            return _cuentaAhorroLogic.Add(c);
            
        }


        [HttpGet("cancelar/{id:int}")]

        public IActionResult CancelarCuenta(int id)
        {
           _cuentaAhorroLogic.CancelarCuenta(id);
            return Ok();
        }

    }
}
