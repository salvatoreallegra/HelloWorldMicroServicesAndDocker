using Microsoft.AspNetCore.Mvc;

namespace HelloCallerService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CallerController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public CallerController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            // Will need the GreeterService address when deployed

            // NEW:  Using environment variables
            var greeterUrl = Environment.GetEnvironmentVariable("GREETER_SERVICE_URL") + "/Greet";

            var response = await _httpClient.GetStringAsync(greeterUrl);
            return $"HelloCallerService says: {response}";
        }
    }
}
