using SnowTraceApi.Net.Core.Converters;
using SnowTraceApi.Net.Core.Models;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Models.Accounts
{
    public class BalancesModel : SnowTraceBaseModel, ISnowTraceModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public List<BalancesData>? BalancesData { get; set; }
    }

    public partial class BalancesData
    {
        [JsonPropertyName("account")]
        public string Account { get; set; } = "";

        [JsonPropertyName("balance")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Balance { get; set; }
    }
}
