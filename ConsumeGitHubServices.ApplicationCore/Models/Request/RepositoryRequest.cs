using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Request
{
    public class RepositoryRequest
    {
        public string? name { get; set; }
        public string? description { get; set; }     
    }
}
