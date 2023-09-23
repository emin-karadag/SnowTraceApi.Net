using SnowTraceApi.Net.Core.Converters;
using SnowTraceApi.Net.Core.Models;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Models.Accounts
{
    public class NormalTransactionsModel : SnowTraceBaseModel, ISnowTraceModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public List<NormalTransactionsData>? TransactionsData { get; set; }
    }

    public partial class NormalTransactionsData
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
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Nonce { get; set; }

        [JsonPropertyName("blockHash")]
        public string BlockHash { get; set; } = "";

        [JsonPropertyName("transactionIndex")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int TransactionIndex { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; } = "";

        [JsonPropertyName("to")]
        public string To { get; set; } = "";

        [JsonPropertyName("value")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Value { get; set; }

        [JsonPropertyName("gas")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Gas { get; set; }

        [JsonPropertyName("gasPrice")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal GasPrice { get; set; }

        [JsonPropertyName("isError")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int IsError { get; set; }

        [JsonPropertyName("txreceipt_status")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int TxreceiptStatus { get; set; }

        [JsonPropertyName("input")]
        public string Input { get; set; } = "";

        [JsonPropertyName("contractAddress")]
        public string? ContractAddress { get; set; }

        [JsonPropertyName("cumulativeGasUsed")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal CumulativeGasUsed { get; set; }

        [JsonPropertyName("gasUsed")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal GasUsed { get; set; }

        [JsonPropertyName("confirmations")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Confirmations { get; set; }

        [JsonPropertyName("methodId")]
        public string MethodId { get; set; } = "";

        [JsonPropertyName("functionName")]
        public string FunctionName { get; set; } = "";
    }
}
