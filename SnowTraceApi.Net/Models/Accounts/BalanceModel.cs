using SnowTraceApi.Net.Core.Converters;
using SnowTraceApi.Net.Core.Models;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Models.Accounts
{
    public class BalanceModel : SnowTraceBaseModel, ISnowTraceModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Result { get; set; }
    }
}
