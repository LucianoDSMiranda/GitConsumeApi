using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Services
{
    public class WebhookService : IWebhookService
    {
        private readonly IWebhookRepository webhookRepository;
        public WebhookService(IWebhookRepository webhookRepository)
        {
            this.webhookRepository = webhookRepository;
        }
        public Task<WebhookResponse> WebhookCreate(WebhookRequest request, string User, string Repo)
        {
            return this.webhookRepository.WebhookCreate(request, User, Repo);
        }

        public Task <WebhookResponse> WebhookGetById(string User, string Repo, int id)
        {
            return this.webhookRepository.WebhookGetById(User, Repo, id);
        }

        public IEnumerable<WebhookResponse> WebhookListByRepository(string User, string Repo)
        {
            return this.webhookRepository.WebhookListByRepository(User, Repo).Result;
        }

        public Task<WebhookResponse> WebhookUpdate(WebhookRequest request, string User, string Repo, int id)
        {
            return this.webhookRepository.WebhookUpdate(request, User, Repo, id);
        }
    }
}
