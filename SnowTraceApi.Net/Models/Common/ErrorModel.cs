using SnowTraceApi.Net.Core.Converters;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Models.Common
{
    public class ErrorModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public string Result { get; set; } = "";
    }
}
