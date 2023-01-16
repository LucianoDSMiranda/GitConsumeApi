using ConsumeGitHubServices.ApplicationCore.Models.Response;
using ConsumeGitHubServices.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Moq;

namespace ConsumeGitHubServices.Tests
{
    public class BranchRepositoryTest
    {
        [Fact]
        public void BuscarBranchs_RecuperaListaDeBranchResponse_ComPeloMenosUmItem()
        {
            // Arrange
            var inMemorySettings = new Dictionary<string, string> {
                {"GitServices:TokenPart1", ""},
                {"GitServices:TokenPart2", ""},
                {"GitServices:TokenPart3", ""},
                {"GitServices:TokenPart4", ""},
                {"GitServices:Url", "https://api.github.com/"},
                {"GitServices:User", ""},
                {"GitServices:Services:RepositoryCreate", "user/repos"},
                {"GitServices:Services:RepositoryListAll", "users/{USER}/repos"},
                {"GitServices:Services:BranchsListByRepository", "repos/{USER}/{REPO}/branches"},
                {"GitServices:Services:WebhookListByRepository", "repos/{USER}/{REPO}/hooks"},
                {"GitServices:Services:WebhookGetById", "repos/{USER}/{REPO}/hooks/{HOOK}"},
                {"GitServices:Services:WebhookUpdate", "repos/{USER}/{REPO}/hooks/{HOOK}"},
                {"GitServices:Services:WebhookCreate", "repos/{USER}/{REPO}/hooks"},
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            var branchRepository = new BranchRepository(configuration);

            // Act
            var result = branchRepository.BranchsListByRepository("InserirUser", "ConsumeGitHubServices").Result;

            // Assert
            Assert.True(result.ToList().Count > 0);
            Assert.IsType<List<BranchResponse>>(result);
        }
    }
}