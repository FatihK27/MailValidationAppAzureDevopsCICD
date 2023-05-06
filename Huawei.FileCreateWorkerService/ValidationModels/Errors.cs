using System.Text.Json.Serialization;

namespace Huawei.RabbitMqSubscriberService.ValidationModels
{
    public class Errors
    {
        [JsonPropertyName("smtp")]
        public string? smtp { get; set; }

        [JsonPropertyName("mailfrom")]
        public string? mailfrom { get; set; }

        [JsonPropertyName("rcpttp")]
        public string? rcptto { get; set; }

        [JsonPropertyName("regex")]
        public string? regex { get; set; }
    }
}
