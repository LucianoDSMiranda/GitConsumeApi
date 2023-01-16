using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class RepositoryRepository : IRepositoryRepository
    {
        private readonly IConfiguration _configuration;
        public RepositoryRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public async Task <RepositoryResponse> RepositoryCreate(RepositoryRequest request)
        {
            var TokenPart1 = _configuration["GitServices:TokenPart1"];
            var TokenPart2 = _configuration["GitServices:TokenPart2"];
            var TokenPart3 = _configuration["GitServices:TokenPart3"];
            var TokenPart4 = _configuration["GitServices:TokenPart4"];
            var token = TokenPart1 + TokenPart2 + TokenPart3 + TokenPart4;
            var baseUrl = _configuration["GitServices:Url"];
            var myservice = _configuration["GitServices:Services:RepositoryCreate"];

            var urlcompleta = $"{baseUrl}{myservice}";

            var resultjson = "";

            using (var cliente = new HttpClient())
            {
                var req = JsonConvert.SerializeObject(request);
                var content = new StringContent(req, Encoding.UTF8, "application/json");
                cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                var response = await cliente.PostAsync(urlcompleta, content);
            }
            var result = JsonConvert.DeserializeObject<RepositoryResponse>(resultjson);
            return result;
        }

        public async Task<IEnumerable<RepositoryResponse>> RepositoryListAll(string User)
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
                var myservice = _configuration["GitServices:Services:RepositoryListAll"];
                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user);

                var urlcompleta = $"{baseUrl}{myservice}";

                var resultjson = "";

                using (var cliente = new HttpClient())
                {
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.GetAsync(urlcompleta);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<IEnumerable<RepositoryResponse>> (resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
