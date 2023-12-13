using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[controller]/")]
        public async Task<string> CallApiAsync()
        {
            _logger.LogInformation("Hello World says the API");
            return await Task.FromResult("Hello World 2 !!");
        }
    }
}