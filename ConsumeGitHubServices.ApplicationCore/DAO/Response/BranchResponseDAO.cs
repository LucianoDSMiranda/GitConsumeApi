using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.DAO.Response
{
    public class BranchResponseDAO
    {
        public string Name { get; set; }
        public CommitDAO Commit { get; set; }
        public bool Protected { get; set; }
    }
    public class CommitDAO
    {
        public string Sha { get; set; }
        public string Url { get; set; }
    }
}
