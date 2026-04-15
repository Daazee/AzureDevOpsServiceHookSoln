using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevOpsServiceHookSoln.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;
        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
            
        }

        [HttpPost]
        public IActionResult ReceiveWebhook([FromBody] object payload)
        {
            _logger.LogInformation($"Request {System.Text.Json.JsonSerializer.Serialize(payload)}");
            return Ok(new
            {
                message = "Okay"
            });
        }
    }
}
