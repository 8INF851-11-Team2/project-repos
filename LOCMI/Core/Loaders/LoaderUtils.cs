namespace LOCMI.Core.Loaders;

public static class LoaderUtils
{
    public static ILoader<T1> GetSameLoader<T1, T2>(ILoader<T2> loader) where T1 : class where T2 : class
    {
        ILoader<T1> newLoader = loader switch
        {
            JsonLoader<T2> json => new JsonLoader<T1>(),
            ExternalClassLoader<T2> external => new ExternalClassLoader<T1>(),
            _ => new JsonLoader<T1>(),
        };

        return newLoader;
    }
}