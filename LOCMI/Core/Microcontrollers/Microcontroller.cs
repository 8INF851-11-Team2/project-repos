namespace LOCMI.Core.Microcontrollers;

using JetBrains.Annotations;
using LOCMI.Core.Microcontrollers.Utils;

[PublicAPI]
public class Microcontroller
{
    public virtual IEnumerable<Connector>? Connectors { get; set; }

    public virtual Dimension? Dimension { get; set; }

    public virtual Disk? Disk { get; set; }

    public virtual Identification? Identification { get; set; }

    public virtual bool IsMaintainable { get; set; }

    public virtual IEnumerable<Language>? Languages { get; set; }

    public virtual string? Name { get; set; }

    public virtual OS? OS { get; set; }

    public virtual Ports? Ports { get; set; }
}