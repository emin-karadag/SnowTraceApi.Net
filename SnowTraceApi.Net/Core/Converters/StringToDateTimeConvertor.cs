using System.Text.Json;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Core.Converters
{
    public class StringToDateTimeConvertor : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType == JsonTokenType.String
                ? DateTimeOffset.FromUnixTimeMilliseconds(Convert.ToInt64(reader.GetString())).DateTime
                : default;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new InvalidOperationException($"Unable to parse {value} to datetime");
        }
    }
}
