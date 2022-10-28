namespace LOCMI.Core;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Core.Utils;
using LOCMI.Noyau;

public interface IMicroControllerAdapter
{ 
    public string BuildName();

    public Dimension BuildDimension();

    public IEnumerable<Port>? BuildPort();

    public IEnumerable<Connecter>? BuildConnecter();

    public Language BuildLanguage();

    public Disk BuildDisk();

    public Identification BuildIdentification();

    public MicroController GetResult()
    {
        string name = BuildName();
        Dimension dimension = BuildDimension();
        IEnumerable<Port>? ports = BuildPort();
        IEnumerable<Connecter>? connecters = BuildConnecter();
        Language language = BuildLanguage();
        Disk disk = BuildDisk();
        Identification identification = BuildIdentification();

        MicroController microcontroller = new MicroController(name, dimension, disk, identification, language)
        {
            Ports = ports, Connecters = connecters,
        };
        
        return microcontroller;
    }
}