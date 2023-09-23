using System.Text.Json;
using System.Text.Json.Serialization;

namespace SnowTraceApi.Net.Core.Converters
{
    public class StringToIntConvertor : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.Number:
                    return reader.GetInt32();
                case JsonTokenType.String:
                    {
                        _ = int.TryParse(reader.GetString(), out int result);
                        return result;
                    }
            }
            return 0;

        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            throw new InvalidOperationException($"Unable to parse {value} to int");
        }
    }
}
