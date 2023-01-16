using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Repository
{
    public interface IRepositoryRepository
    {
        public Task<RepositoryResponse> RepositoryCreate(RepositoryRequest request);
        public Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User);
    }
}