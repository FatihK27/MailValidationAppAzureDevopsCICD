using System.Text.Json.Serialization;

namespace Huawei.RabbitMqSubscriberService.ValidationModels
{
    public class Root
    {
        [JsonPropertyName("date")]
        public string date { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("validation_type")]
        public string validation_type { get; set; }

        [JsonPropertyName("success")]
        public bool? success { get; set; }

        [JsonPropertyName("errors")]
        public Errors errors { get; set; }

        [JsonPropertyName("smtp_debug")]
        public List<SmtpDebug> smtp_debug { get; set; }

        [JsonPropertyName("configuration")]
        public Configuration configuration { get; set; }
    }
}
