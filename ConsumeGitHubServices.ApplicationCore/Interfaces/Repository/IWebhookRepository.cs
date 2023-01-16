using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Repository
{
    public interface IWebhookRepository
    {
        Task<WebhookResponse> WebhookCreate(WebhookRequest request, string User, string Repo);
        Task<WebhookResponse> WebhookUpdate(WebhookRequest request, string User, string Repo, int id);
        Task <WebhookResponse> WebhookGetById(string User, string Repo, int id);
        Task<IEnumerable<WebhookResponse>> WebhookListByRepository(string User, string Repo);
    }
}