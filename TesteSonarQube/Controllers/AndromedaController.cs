using Microsoft.AspNetCore.Mvc;

namespace TesteSonarQube.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AndromedaController : ControllerBase
    {

        [HttpGet("genesis")]
        public OkObjectResult Genesis()
        {
            string response = "teste";
            return Ok(response);
        }

        [HttpGet("andromeda")]
        public OkObjectResult Andromeda()
        {
            string response = "lançar correntes!";
            return Ok(response);
        }
    }
}
