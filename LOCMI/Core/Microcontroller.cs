namespace LOCMI.Noyau;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Core.Utils;

public class MicroController
{
    public MicroController(string name, Dimension dimension, Disk disk, Identification identification, Language language)
    {
        Name = name;
        Dimension = dimension;
        Disk = disk;
        Identification = identification;
        Language = language;
    }

    public IEnumerable<Connecter>? Connecters { get; init; }

    public Dimension Dimension { get; }

    public Disk Disk { get; }

    public Identification Identification { get; }

    public Language Language { get; }

    public string Name { get; }

    public IEnumerable<Port>? Ports { get; init; }
}
