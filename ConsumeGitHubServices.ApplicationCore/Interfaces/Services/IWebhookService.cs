using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Services
{
    public interface IWebhookService
    {
        public Task<WebhookResponse> WebhookCreate(WebhookRequest request, string User, string Repo);
        public Task<WebhookResponse> WebhookUpdate(WebhookRequest request, string User, string Repo, int id);
        public Task <WebhookResponse> WebhookGetById(string User, string Repo, int id);
        public IEnumerable<WebhookResponse> WebhookListByRepository(string User, string Repo);
    }
}
