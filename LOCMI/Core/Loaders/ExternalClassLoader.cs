namespace LOCMI.Core.Loaders;

using System.Reflection;

public sealed class ExternalClassLoader<T> : ILoader<T> where T : class
{
    /// <inheritdoc />
    public T? Load(string path)
    {
        Assembly assembly = Assembly.LoadFile(path);

        Type type = typeof(T);

        Type? externType = assembly.GetExportedTypes().FirstOrDefault(c => c.BaseType == type);

        return externType != null
                   ? Activator.CreateInstance(externType) as T
                   : null;
    }

    private T? LoadDll(string path)
    {
        Assembly assembly = Assembly.LoadFile(path);

        Type type = typeof(T);

        Type? externType = assembly.GetExportedTypes().FirstOrDefault(c => c.BaseType == type);

        return externType != null
                   ? Activator.CreateInstance(externType) as T
                   : null;
    }
}