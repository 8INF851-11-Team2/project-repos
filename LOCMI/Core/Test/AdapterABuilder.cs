namespace LOCMI.Core.Test;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using LOCMI.Core.Utils;
using LOCMI.Noyau;

internal class AdapterABuilder : IMicroControllerAdapter
{
    private AdapterA _adapterA = new AdapterA();
    public IEnumerable<Connecter>? BuildConnecter()
    {
        List<Connecter> list = new List<Connecter>();
        list.Add(new Connecter(_adapterA.ConnecterName));
        return list;
    }

    public Dimension BuildDimension()
    {
        return new Dimension(_adapterA.DimensionLength, _adapterA.DimensionWidth, _adapterA.DimensionHeigh, _adapterA.DimensionWeight);
    }

    public Disk BuildDisk()
    {
        return new Disk(_adapterA.DiskName);
    }

    public Identification BuildIdentification()
    {
        return new Identification(_adapterA.IdentificationBrand, _adapterA.IdentificationModel);
    }

    public Language BuildLanguage()
    {
        return new Language(_adapterA.LanguageName, _adapterA.LanguageVersion);
    }

    public string BuildName()
    {
        return _adapterA.Name;
    }

    public IEnumerable<Port>? BuildPort()
    {
        List<Port> list = new List<Port>();
        list.Add(new Port(_adapterA.NumPin, _adapterA.Data, _adapterA.Ground, _adapterA.Power));
        return list;
    }

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
            Ports = ports,
            Connecters = connecters,
        };

        return microcontroller;
    }
}
