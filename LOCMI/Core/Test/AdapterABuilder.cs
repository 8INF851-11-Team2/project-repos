namespace LOCMI.Core.Test;

using LOCMI.Core.Utils;

internal sealed class AdapterABuilder : IMicrocontrollerAdapter
{
    private readonly AdapterA _adapterA = new ();

    public IEnumerable<Connector> BuildConnectors()
    {
        var list = new List<Connector> { new (_adapterA.ConnectorName) };
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

    public IEnumerable<Port> BuildPort()
    {
        var list = new List<Port> { new (_adapterA.NumPin, _adapterA.Data, _adapterA.Ground, _adapterA.Power) };
        return list;
    }

    public Microcontroller GetResult()
    {
        string name = BuildName();
        Dimension dimension = BuildDimension();
        IEnumerable<Port> ports = BuildPort();
        IEnumerable<Connector> connecters = BuildConnectors();
        Language language = BuildLanguage();
        Disk disk = BuildDisk();
        Identification identification = BuildIdentification();

        var microcontroller = new Microcontroller(name, dimension, disk, identification, language)
        {
            Ports = ports, Connectors = connecters,
        };

        return microcontroller;
    }
}