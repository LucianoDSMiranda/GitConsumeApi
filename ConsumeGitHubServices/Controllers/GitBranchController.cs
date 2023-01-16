using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GitBranchController : ControllerBase
    {

        private readonly IBranchService branchService;
        public GitBranchController(IBranchService branchService)
        {
            this.branchService = branchService;
        }

        [HttpGet("BranchsListByRepository/{Repo}")]
        public Task <IEnumerable<BranchResponse>> BranchsListByRepository(string Repo)
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = this.branchService.BranchsListByRepository(User, Repo);

            return result;
        }
    }
}