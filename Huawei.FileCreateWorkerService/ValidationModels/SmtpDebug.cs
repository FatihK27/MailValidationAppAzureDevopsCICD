using System.Text.Json.Serialization;

namespace Huawei.RabbitMqSubscriberService.ValidationModels
{
    public class SmtpDebug
    {
        [JsonPropertyName("mail_host")]
        public string mail_host { get; set; }

        [JsonPropertyName("port_opened")]
        public bool? port_opened { get; set; }

        [JsonPropertyName("connection")]
        public bool? connection { get; set; }

        [JsonPropertyName("errors")]
        public Errors errors { get; set; }
    }
}
