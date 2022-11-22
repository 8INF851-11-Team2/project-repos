namespace LOCMI.Core.Loaders;

using System.Text.Json;

public sealed class JsonLoader<T> : ILoader<T> where T : class
{
    /// <inheritdoc />
    public T? Load(string path)
    {
        try
        {
            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }
        catch (Exception ex)
        {
            throw new LoadException("Unable to load this object", ex);
        }
    }
}