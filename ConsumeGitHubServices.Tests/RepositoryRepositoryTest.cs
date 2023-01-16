using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using ConsumeGitHubServices.Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Moq;

namespace ConsumeGitHubServices.Tests
{
    public class RepositoryRepositoryTest
    {
        [Fact]
        public void BuscarRepositorios_RecuperaListaDeRepositoryResponse_ComPeloMenosUmItem()
        {
            // Arrange
            var inMemorySettings = new Dictionary<string, string> {
                {"GitServices:TokenPart1", ""},
                {"GitServices:TokenPart2", ""},
                {"GitServices:TokenPart3", ""},
                {"GitServices:TokenPart4", ""},
                {"GitServices:Url", "https://api.github.com/"},
                {"GitServices:User", "InserirUser"},
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

            var repositoryRepository = new RepositoryRepository(configuration);

            // Act
            var result = repositoryRepository.RepositoryListAll("").Result;

            // Assert
            Assert.True(result.ToList().Count > 0);
            Assert.IsType<List<RepositoryResponse>>(result);
        }

        [Fact]
        public void CriarRepositorio()
        {
            // Arrange
            var repositoryRequest = new RepositoryRequest() { description = "Teste", name = "Teste" };
            var repositoryResponse = new RepositoryResponse() { FullName = "Teste", Id = 123 };

            var repositoryRepository = new Mock<IRepositoryRepository>();
            repositoryRepository.Setup(p => p.RepositoryCreate(It.IsAny<RepositoryRequest>())).Returns(Task.FromResult(repositoryResponse));

            // Act
            var result = repositoryRepository.Object.RepositoryCreate(repositoryRequest).Result;

            // Assert
            Assert.Equal(repositoryResponse.Id, result.Id);
            Assert.Equal(repositoryResponse.FullName, result.FullName);
        }
    }
}