namespace LOCMI.Core.Utils;

public class Language
{
    public Language(string name, string version)
    {
        Name = name;
        Version = version;
    }

    public string Name { get; }

    public string Version { get; }
}