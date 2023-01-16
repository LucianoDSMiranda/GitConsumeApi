using ConsumeGitHubServices.ApplicationCore.Interfaces.Repository;
using ConsumeGitHubServices.ApplicationCore.Models.Request;
using ConsumeGitHubServices.ApplicationCore.Models.Response;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text;

namespace ConsumeGitHubServices.Infrastructure.Repository
{
    public class WebhookRepository : IWebhookRepository
    {
        private readonly IConfiguration _configuration;
        public WebhookRepository(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public async Task<WebhookResponse> WebhookCreate(WebhookRequest request, string User, string Repo)
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
                var myservice = _configuration["GitServices:Services:WebhookCreate"];
                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user).Replace("{REPO}", Repo);

                var urlcompleta = $"{baseUrl}{myservice}";

                var resultjson = "";  

                using (var cliente = new HttpClient())
                {
                    var req = JsonConvert.SerializeObject(request);
                    var content = new StringContent(req, Encoding.UTF8, "application/json");
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.PostAsync(urlcompleta, content);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<WebhookResponse>(resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task <WebhookResponse> WebhookGetById(string User, string Repo, int Id)
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
                var myservice = _configuration["GitServices:Services:WebhookGetById"];
                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user).Replace("{REPO}", Repo).Replace("{HOOK}", Id.ToString());

                var urlcompleta = $"{baseUrl}{myservice}";

                var resultjson = "";
                using (var cliente = new HttpClient())
                {
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.GetAsync(urlcompleta);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<WebhookResponse>(resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<WebhookResponse>> WebhookListByRepository(string User, string Repo)
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
                var myservice = _configuration["GitServices:Services:WebhookListByRepository"];

                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user).Replace("{REPO}", Repo);

                //https://api.github.com/repos/InserirUser/ConsumeGitHubServices/hooks
                var urlcompleta = $"{baseUrl}{myservice}";
            
                var resultjson = "";
                using (var cliente = new HttpClient())
                {
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.GetAsync(urlcompleta);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<IEnumerable<WebhookResponse>>(resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<WebhookResponse> WebhookUpdate(WebhookRequest request, string User, string Repo, int Id)
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
                var myservice = _configuration["GitServices:Services:WebhookUpdate"];
                if (User != user)
                {
                    throw new Exception($"Este exemplo somente aceita o usuário {user}");
                }

                myservice = myservice.Replace("{USER}", user).Replace("{REPO}", Repo).Replace("{HOOK}", Id.ToString());

                var urlcompleta = $"{baseUrl}{myservice}";

                var resultjson = "";

                using (var cliente = new HttpClient())
                {
                    var req = JsonConvert.SerializeObject(request);
                    var content = new StringContent(req, Encoding.UTF8, "application/json");
                    cliente.DefaultRequestHeaders.Add("User-Agent", "ConsumeGitHubServicesApplication");
                    cliente.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    var response = await cliente.PatchAsync(urlcompleta, content);
                    resultjson = await response.Content.ReadAsStringAsync();
                }
                var result = JsonConvert.DeserializeObject<WebhookResponse>(resultjson);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
