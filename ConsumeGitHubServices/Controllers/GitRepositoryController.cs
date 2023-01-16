using ConsumeGitHubServices.ApplicationCore.Interfaces.Services;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeGitHubServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GitRepositoryController : ControllerBase
    {

        private readonly IRepositoryService repositoryService;
        public GitRepositoryController(IRepositoryService repositoryService)
        {
            this.repositoryService = repositoryService;
        }

        [HttpGet("RepositoryListAll")]
        public async Task<IEnumerable<RepositoryResponse>> RepositoryListAll()
        {
            var User = "InserirUser"; //o usuário será hardcoded para esse exemplo.
            var result = await this.repositoryService.RepositoryListAll(User);

            return result;
        }

        [HttpPost("RepositoryCreate")]
        public Task <RepositoryResponse> RepositoryCreate(RepositoryRequest request)
        {

            var result = this.repositoryService.RepositoryCreate(request);

            return result;
        }
    }
}