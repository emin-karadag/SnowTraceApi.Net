using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Core.Converters
{
    public class StringToDecimalConvertor : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            decimal result = 0;
            if (reader.TokenType == JsonTokenType.String)
            {
                decimal.TryParse(reader.GetString(), NumberStyles.Float, CultureInfo.InvariantCulture, out result);
            }
            else if (reader.TokenType == JsonTokenType.Number)
            {
                reader.TryGetDecimal(out result);
            }
            return result;
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            throw new InvalidOperationException($"Unable to parse {value} to decimal");
        }
    }
}
