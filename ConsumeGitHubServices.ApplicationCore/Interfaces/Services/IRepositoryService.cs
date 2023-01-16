using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Services
{
    public interface IRepositoryService
    {
        public Task <RepositoryResponse> RepositoryCreate(RepositoryRequest request);
        public Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User);
    }
}
