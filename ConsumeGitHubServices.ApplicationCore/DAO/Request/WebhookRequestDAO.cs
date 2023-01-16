using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.DAO.Request
{
    public class WebhookRequestDAO
    {
        public bool Active { get; set; }
        public List<string> Events { get; set; }
        public ConfigDAO Config { get; set; }
    }
    public class ConfigDAO
    {
        public string Url { get; set; }
        public string ContentType { get; set; }
        public string InsecureSsl { get; set; }
    }
}
