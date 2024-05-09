using Microsoft.AspNetCore.Mvc;

namespace GreeterService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, World from GreeterService!";
        }
    }
}
