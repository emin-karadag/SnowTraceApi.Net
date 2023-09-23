using SnowTraceApi.Net.Core.Converters;
using SnowTraceApi.Net.Core.Models;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Models.Accounts
{
    public class TokenTransferEventsModel : SnowTraceBaseModel, ISnowTraceModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public List<TokenTransferEventsData>? TokenTransferEventsData { get; set; }
    }

    public partial class TokenTransferEventsData
    {
        [JsonPropertyName("blockNumber")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long BlockNumber { get; set; }

        [JsonPropertyName("timeStamp")]
        [JsonConverter(typeof(StringToDateTimeConvertor))]
        public DateTime TimeStamp { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = "";

        [JsonPropertyName("nonce")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Nonce { get; set; }

        [JsonPropertyName("blockHash")]
        public string BlockHash { get; set; } = "";

        [JsonPropertyName("from")]
        public string From { get; set; } = "";

        [JsonPropertyName("contractAddress")]
        public string ContractAddress { get; set; } = "";

        [JsonPropertyName("to")]
        public string To { get; set; } = "";

        [JsonPropertyName("value")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Value { get; set; }

        [JsonPropertyName("tokenName")]
        public string TokenName { get; set; } = "";

        [JsonPropertyName("tokenSymbol")]
        public string TokenSymbol { get; set; } = "";

        [JsonPropertyName("tokenDecimal")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal TokenDecimal { get; set; }

        [JsonPropertyName("transactionIndex")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int TransactionIndex { get; set; }

        [JsonPropertyName("gas")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Gas { get; set; }

        [JsonPropertyName("gasPrice")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal GasPrice { get; set; }

        [JsonPropertyName("gasUsed")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal GasUsed { get; set; }

        [JsonPropertyName("cumulativeGasUsed")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal CumulativeGasUsed { get; set; }

        [JsonPropertyName("input")]
        public string Input { get; set; } = "";

        [JsonPropertyName("confirmations")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Confirmations { get; set; }
    }
}
