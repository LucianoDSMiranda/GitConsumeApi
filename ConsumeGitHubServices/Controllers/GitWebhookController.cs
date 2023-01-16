using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitWebhookController : ControllerBase
    {
        private readonly IWebhookService webhookService;
        public GitWebhookController(IWebhookService webhookService)
        {
            this.webhookService = webhookService;
        }

        [HttpGet("WebhookGetById/{Repo}/{id}")]
        public Task <WebhookResponse> WebhookGetById(string Repo, int id)
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = this.webhookService.WebhookGetById(User, Repo, id);
            return result;
        }

        [HttpGet("WebhookListByRepository/{Repo}")]
        public IEnumerable<WebhookResponse> WebhookListByRepository(string Repo)
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = this.webhookService.WebhookListByRepository(User, Repo);
            return result;
        }

        [HttpPost("WebhookCreate/{Repo}")]
        public Task<WebhookResponse> WebhookCreate([FromBody] WebhookRequest request, string Repo)
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = webhookService.WebhookCreate(request, User, Repo);
            return result;
        }

        [HttpPut("WebhookUpdate/{Repo}/{id}")]
        public Task<WebhookResponse> WebhookUpdate([FromBody] WebhookRequest request, string Repo, int id)
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = webhookService.WebhookUpdate(request, User, Repo, id);
            return result;
        }
    }
}