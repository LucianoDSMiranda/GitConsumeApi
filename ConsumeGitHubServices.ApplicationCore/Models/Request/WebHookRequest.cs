using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Request
{
    public class WebhookRequest
    {
        public bool? active { get; set; }
        public List<string>? events { get; set; }
        public ConfigRequest? config { get; set; }
    }
    public class ConfigRequest
    {
        public string? url { get; set; }
        public string? content_Type { get; set; }
        public string? insecure_Ssl { get; set; }
    }
}
