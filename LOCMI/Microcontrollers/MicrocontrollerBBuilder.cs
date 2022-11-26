namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;

internal sealed class MicrocontrollerBBuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = MicrocontrollerB.Connectors.Select(static c => new Connector(c));

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        (int weight, int length, double width, double height) = MicrocontrollerB.Dimension;

        _microcontroller.Dimension = new Dimension(length, width, height, weight);

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDisk()
    {
        _microcontroller.Disk = MicrocontrollerB.Disk;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildIdentification()
    {
        _microcontroller.Identification = new Identification(MicrocontrollerB.Brand, MicrocontrollerB.Model);

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        _microcontroller.Languages = new List<Language>
        {
            new (MicrocontrollerB.Language, MicrocontrollerB.LanguageVersion),
        };

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildMaintenance()
    {
        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildName()
    {
        _microcontroller.Name = MicrocontrollerB.Name;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildOS()
    {
        _microcontroller.OS = MicrocontrollerB.OS;
        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildPort()
    {
        _microcontroller.Ports = MicrocontrollerB.GPIO;
        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildDimension().BuildConnectors().BuildDisk().BuildIdentification().BuildLanguage().BuildMaintenance().BuildName().BuildPort().BuildOS();

        return _microcontroller;
    }
}