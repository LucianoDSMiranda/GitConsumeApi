using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Services
{
    public class RepositoryService : IRepositoryService
    {

        private readonly IRepositoryRepository repositoryRepository;
        public RepositoryService(IRepositoryRepository repositoryRepository)
        {
            this.repositoryRepository = repositoryRepository;
        }
        public Task <RepositoryResponse> RepositoryCreate(RepositoryRequest request)
        {
            return repositoryRepository.RepositoryCreate(request);
        }

        public async Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User)
        {
            return await repositoryRepository.RepositoryListAll(User);
        }
    }
}
