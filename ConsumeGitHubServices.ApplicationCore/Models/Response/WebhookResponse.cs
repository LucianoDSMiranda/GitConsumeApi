using Newtonsoft.Json;


namespace ConsumeGitHubServices.ApplicationCore.Models.Response
{
    public class WebhookResponse
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Events { get; set; }

        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Config Config { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("test_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TestUrl { get; set; }

        [JsonProperty("ping_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri PingUrl { get; set; }

        [JsonProperty("deliveries_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DeliveriesUrl { get; set; }

        [JsonProperty("last_response", NullValueHandling = NullValueHandling.Ignore)]
        public LastResponse LastResponse { get; set; }
    }

    public class Config
    {
        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [JsonProperty("insecure_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public long? InsecureSsl { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    public class LastResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public long? Code { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }


}
