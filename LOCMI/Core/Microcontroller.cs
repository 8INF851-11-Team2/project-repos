namespace LOCMI.Core;

using LOCMI.Core.Utils;

public sealed class Microcontroller
{
    public IEnumerable<Connector>? Connectors { get; set; }

    public Dimension? Dimension { get; set; }

    public Disk? Disk { get; set; }

    public Identification? Identification { get; set; }

    public Language? Language { get; set; }

    public string? Name { get; set; }

    public Ports? Ports { get; set; }
}