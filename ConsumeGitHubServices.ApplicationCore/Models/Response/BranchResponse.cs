using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Response
{
    public class BranchResponse
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public Commit Commit { get; set; }

        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        [JsonProperty("protection", NullValueHandling = NullValueHandling.Ignore)]
        public Protection Protection { get; set; }

        [JsonProperty("protection_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ProtectionUrl { get; set; }
    }
    public class Commit
    {
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }
    public class Protection
    {
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        [JsonProperty("required_status_checks", NullValueHandling = NullValueHandling.Ignore)]
        public RequiredStatusChecks RequiredStatusChecks { get; set; }
    }
    public partial class RequiredStatusChecks
    {
        [JsonProperty("enforcement_level", NullValueHandling = NullValueHandling.Ignore)]
        public string EnforcementLevel { get; set; }

        [JsonProperty("contexts", NullValueHandling = NullValueHandling.Ignore)]
        public System.Collections.Generic.List<object> Contexts { get; set; }

        [JsonProperty("checks", NullValueHandling = NullValueHandling.Ignore)]
        public System.Collections.Generic.List<object> Checks { get; set; }
    }
}
