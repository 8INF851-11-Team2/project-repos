namespace LOCMI.Core.Microcontrollers;

using LOCMI.Core.Microcontrollers.Utils;

public sealed class Microcontroller
{
    public IEnumerable<Connector>? Connectors { get; set; }

    public Dimension? Dimension { get; set; }

    public Disk? Disk { get; set; }

    public Identification? Identification { get; set; }

    public bool IsMaintainable { get; set; } = false;

    public IEnumerable<Language>? Languages { get; set; }

    public string? Name { get; set; }

    public OS? OS { get; set; }

    public Ports? Ports { get; set; }
}