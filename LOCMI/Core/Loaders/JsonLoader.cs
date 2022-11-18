namespace LOCMI.Core.Loaders;

using System.Text.Json;
using System.Text.Json.Serialization;

public sealed class JsonLoader<T> : ILoader<T> where T : class
{
    /// <inheritdoc />
    /// <exception cref="FileNotFoundException">The file isn't found.</exception>
    /// <exception cref="JsonException">The Json can't be parsed.</exception>
    /// <exception cref="NotSupportedException">No <see cref="JsonConverter" /> exists.</exception>
    public T? Load(string path)
    {
        string json = File.ReadAllText(path);

        return JsonSerializer.Deserialize<T>(json);
    }
}