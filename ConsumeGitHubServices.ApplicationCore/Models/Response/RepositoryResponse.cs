using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeGitHubServices.ApplicationCore.Models.Response
{
    public class RepositoryResponse
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [JsonProperty("private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("fork", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fork { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("forks_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ForksUrl { get; set; }

        [JsonProperty("keys_url", NullValueHandling = NullValueHandling.Ignore)]
        public string KeysUrl { get; set; }

        [JsonProperty("collaborators_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("teams_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("hooks_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HooksUrl { get; set; }

        [JsonProperty("issue_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("events_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri EventsUrl { get; set; }

        [JsonProperty("assignees_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneesUrl { get; set; }

        [JsonProperty("branches_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchesUrl { get; set; }

        [JsonProperty("tags_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TagsUrl { get; set; }

        [JsonProperty("blobs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobsUrl { get; set; }

        [JsonProperty("git_tags_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_refs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitRefsUrl { get; set; }

        [JsonProperty("trees_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TreesUrl { get; set; }

        [JsonProperty("statuses_url", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusesUrl { get; set; }

        [JsonProperty("languages_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("stargazers_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("contributors_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ContributorsUrl { get; set; }

        [JsonProperty("subscribers_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscription_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("commits_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitsUrl { get; set; }

        [JsonProperty("git_commits_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("comments_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CommentsUrl { get; set; }

        [JsonProperty("issue_comment_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("contents_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentsUrl { get; set; }

        [JsonProperty("compare_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareUrl { get; set; }

        [JsonProperty("merges_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri MergesUrl { get; set; }

        [JsonProperty("archive_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchiveUrl { get; set; }

        [JsonProperty("downloads_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("issues_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuesUrl { get; set; }

        [JsonProperty("pulls_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PullsUrl { get; set; }

        [JsonProperty("milestones_url", NullValueHandling = NullValueHandling.Ignore)]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notifications_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationsUrl { get; set; }

        [JsonProperty("labels_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelsUrl { get; set; }

        [JsonProperty("releases_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleasesUrl { get; set; }

        [JsonProperty("deployments_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("pushed_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PushedAt { get; set; }

        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        [JsonProperty("ssh_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SshUrl { get; set; }

        [JsonProperty("clone_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri CloneUrl { get; set; }

        [JsonProperty("svn_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SvnUrl { get; set; }

        [JsonProperty("homepage")]
        public object Homepage { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        [JsonProperty("stargazers_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? StargazersCount { get; set; }

        [JsonProperty("watchers_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? WatchersCount { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("has_issues", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasIssues { get; set; }

        [JsonProperty("has_projects", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasProjects { get; set; }

        [JsonProperty("has_downloads", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasDownloads { get; set; }

        [JsonProperty("has_wiki", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasWiki { get; set; }

        [JsonProperty("has_pages", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPages { get; set; }

        [JsonProperty("has_discussions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasDiscussions { get; set; }

        [JsonProperty("forks_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ForksCount { get; set; }

        [JsonProperty("mirror_url")]
        public object MirrorUrl { get; set; }

        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; }

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        [JsonProperty("open_issues_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? OpenIssuesCount { get; set; }

        [JsonProperty("license")]
        public object License { get; set; }

        [JsonProperty("allow_forking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowForking { get; set; }

        [JsonProperty("is_template", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTemplate { get; set; }

        [JsonProperty("web_commit_signoff_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebCommitSignoffRequired { get; set; }

        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public System.Collections.Generic.List<object> Topics { get; set; }

        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        [JsonProperty("forks", NullValueHandling = NullValueHandling.Ignore)]
        public long? Forks { get; set; }

        [JsonProperty("open_issues", NullValueHandling = NullValueHandling.Ignore)]
        public long? OpenIssues { get; set; }

        [JsonProperty("watchers", NullValueHandling = NullValueHandling.Ignore)]
        public long? Watchers { get; set; }

        [JsonProperty("default_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Permissions Permissions { get; set; }
    }
    public class Owner
    {
        [JsonProperty("login", NullValueHandling = NullValueHandling.Ignore)]
        public string Login { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GravatarId { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url", NullValueHandling = NullValueHandling.Ignore)]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("site_admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SiteAdmin { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin { get; set; }

        [JsonProperty("maintain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Maintain { get; set; }

        [JsonProperty("push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Push { get; set; }

        [JsonProperty("triage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Triage { get; set; }

        [JsonProperty("pull", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pull { get; set; }

    }
}
