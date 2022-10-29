namespace LOCMI.Core;

using LOCMI.Core.Utils;

public interface IMicrocontrollerAdapter
{
    public IEnumerable<Connector>? BuildConnectors();

    public Dimension BuildDimension();

    public Disk BuildDisk();

    public Identification BuildIdentification();

    public Language BuildLanguage();

    public string BuildName();

    public IEnumerable<Port>? BuildPort();

    public Microcontroller GetResult();
}