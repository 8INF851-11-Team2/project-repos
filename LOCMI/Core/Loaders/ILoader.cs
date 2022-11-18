namespace LOCMI.Core.Loaders;

public interface ILoader<out T> where T : class
{
    public T? Load(string path);
}