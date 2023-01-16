using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class BranchRepository : IBranchRepository
    {
        private readonly IConfiguration _configuration;
        public BranchRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public async Task <IEnumerable<BranchResponse>> BranchsListByRepository(string User, string Repo)
        {
            try
            {
                var TokenPart1 = _configuration["GitServices:TokenPart1"];
                var TokenPart2 = _configuration["GitServices:TokenPart2"];
                var TokenPart3 = _configuration["GitServices:TokenPart3"];
                var TokenPart4 = _configuration["GitServices:TokenPart4"];
                var token = TokenPart1 + TokenPart2 + TokenPart3 + TokenPart4;
                var user = _configuration["GitServices:User"];
                var baseUrl = _configuration["GitServices:Url"];
                var myservice = _configuration["GitServices:Services:BranchsListByRepository"];
                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user).Replace("{REPO}", Repo);

                var urlcompleta = $"{baseUrl}{myservice}";

                var resultjson = "";

                using (var cliente = new HttpClient())
                {                                        
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.GetAsync(urlcompleta);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<IEnumerable<BranchResponse>>(resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

