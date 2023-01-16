using ConsumeGitHubServices.ApplicationCore.Models.Response;

namespace ConsumeGitHubServices.ApplicationCore.Interfaces.Repository
{
    public interface IBranchRepository
    {
        public Task <IEnumerable<BranchResponse>> BranchsListByRepository(string User, string Repo);
    }
}
