namespace LOCMI.Core.Loaders;

using System.Reflection;

public sealed class ExternalClassLoader<T> : ILoader<T> where T : class
{
    /// <inheritdoc />
    public T? Load(string path)
    {
        try
        {
            Assembly assembly = Assembly.LoadFile(path);

            Type type = typeof(T);

            Type? externType = assembly.GetExportedTypes().FirstOrDefault(c => c.IsAssignableTo(type));

            return externType != null
                       ? Activator.CreateInstance(externType) as T
                       : null;
        }
        catch (Exception ex)
        {
            throw new LoadException($"Unable to load this dll (path: {path})", ex);
        }
    }
}