namespace LOCMI.Core.Loaders.Json;

using System.Text.Json;
using System.Text.Json.Serialization;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public sealed class PortsJsonConverter : JsonConverter<Ports>
{
    /// <inheritdoc />
    public override Ports Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.StartObject)
        {
            throw new JsonException();
        }

        var ports = new Ports();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
            {
                return ports;
            }

            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            string? numPinStr = reader.GetString();

            if (!int.TryParse(numPinStr, out int numPin))
            {
                throw new JsonException($"The port's property name must be an integer (current property name: {numPinStr})");
            }

            reader.Read();
            var port = JsonSerializer.Deserialize<Port>(ref reader, options);

            ports[numPin] = port;
        }

        throw new JsonException();
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Ports value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        for (var i = 1; i < value.Count + 1; i++)
        {
            Port? port = value[i];

            var propertyName = i.ToString();

            writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propertyName) ?? propertyName);

            if (port == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                JsonSerializer.Serialize(writer, port, options);
            }
        }

        writer.WriteEndObject();
    }
}