using Credyty.CustomTypes;
using Credyty.Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Credyty.WebApi.Controllers
{
    [Route("cliente")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClienteLogic _clienteLogic;
        private readonly ILogger<ClientController> _logger;
        public ClientController(
            ILogger<ClientController> logger,
            IClienteLogic clienteLogic)
        {
            _logger = logger;
            _clienteLogic = clienteLogic;
        }


        [HttpPost]
        public IActionResult Add(ClienteModel c)
        {
            _clienteLogic.Add(c);
            return Ok();

        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clienteLogic.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public ClienteModel Get(int id)
        {
           return _clienteLogic.Get(id);
        }


        [HttpGet]
        public List<ClienteModel> GetAll()
        {
            return _clienteLogic.GetAll();
        }


        [HttpPut]
        public IActionResult Update(ClienteModel c)
        {
            _clienteLogic.Update(c);
            return Ok();
        }

    }
}
