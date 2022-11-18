namespace LOCMI.Core.Loaders;

public interface ILoader<out T> where T : class
{
    /// <summary>
    ///     Load a <see cref="T" /> object.
    /// </summary>
    /// <param name="path">The file path</param>
    /// <returns></returns>
    /// <exception cref="LoadException">An exception has throw in the load.</exception>
    public T? Load(string path);
}