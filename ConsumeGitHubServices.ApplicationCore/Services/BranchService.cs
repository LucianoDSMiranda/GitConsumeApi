using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Services
{
    public class BranchService : IBranchService
    {
        private readonly IBranchRepository branchRepository;
        public BranchService(IBranchRepository branchRepository)
        {
            this.branchRepository = branchRepository;
        }
        public Task <IEnumerable<BranchResponse>> BranchsListByRepository(string User, string Repo)
        {
            return this.branchRepository.BranchsListByRepository(User, Repo);
        }
    }
}
