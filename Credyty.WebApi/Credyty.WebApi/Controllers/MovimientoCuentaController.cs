using Credyty.CustomTypes;
using Credyty.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Credyty.WebApi.Controllers
{
    [Route("movimientocuenta")]
    [ApiController]
    public class MovimientoCuentaController : ControllerBase
    {

        private IMovimientoCuentaLogic _movimientoCuentaLogic;
        private ILogger<MovimientoCuentaController> _logger;

        public MovimientoCuentaController(
            IMovimientoCuentaLogic movimientoCuentaLogic,
            ILogger<MovimientoCuentaController> logger
            )
        {
            _movimientoCuentaLogic = movimientoCuentaLogic;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add(MovimientoCuentaModel c)
        {    
            _movimientoCuentaLogic.Add(c);
            return Ok();
        }
    }
}
