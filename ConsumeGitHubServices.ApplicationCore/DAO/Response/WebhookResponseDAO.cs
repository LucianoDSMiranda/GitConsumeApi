using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.DAO.Response
{
    public class WebhookResponseDAO
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public List<string> Events { get; set; }
        public ConfigDAO Config { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Url { get; set; }
        public string TestUrl { get; set; }
        public string PingUrl { get; set; }
        public string DeliveriesUrl { get; set; }
        public LastResponseDAO LastResponse { get; set; }
    }
    public class ConfigDAO
    {
        public string ContentType { get; set; }
        public string InsecureSsl { get; set; }
        public string Url { get; set; }
    }

    public class LastResponseDAO
    {
        public int Code { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
