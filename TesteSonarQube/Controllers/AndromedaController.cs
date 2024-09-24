using Microsoft.AspNetCore.Mvc;

namespace TesteSonarQube.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AndromedaController : ControllerBase
    {

        [HttpGet("nani")]
        public IActionResult Genesis()
        {
            string response = "teste";
            return Ok(response);
        }
    }
}
