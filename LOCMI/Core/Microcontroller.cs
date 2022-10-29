namespace LOCMI.Core;

using LOCMI.Core.Utils;

public class Microcontroller
{
    public Microcontroller(string name, Dimension dimension, Disk disk, Identification identification, Language language)
    {
        Name = name;
        Dimension = dimension;
        Disk = disk;
        Identification = identification;
        Language = language;
    }

    public IEnumerable<Connector>? Connectors { get; init; }

    public Dimension Dimension { get; }

    public Disk Disk { get; }

    public Identification Identification { get; }

    public Language Language { get; }

    public string Name { get; }

    public IEnumerable<Port>? Ports { get; init; }
}