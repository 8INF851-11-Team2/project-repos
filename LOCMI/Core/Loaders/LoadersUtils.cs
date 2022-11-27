namespace LOCMI.Core.Loaders;

using LOCMI.Core.Certificates;
using LOCMI.Views;

public static class LoadersUtils
{
    public static ILoader<T1> GetSameLoader<T1, T2>(ILoader<T2> loader) 
        where T1 : class 
        where T2 : class
    {
        switch (loader.GetType().Name)
        {
            case "JsonLoader`1":
                return new JsonLoader<T1>();
            case "ExternalClassLoader`1":
                return new ExternalClassLoader<T1>();
            default:
                return new JsonLoader<T1>();
        }
    }

}
