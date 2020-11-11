using Microsoft.AspNetCore.Mvc;

namespace Credyty.WebApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get() {
            return "Corriendo";
        }
    }
}
