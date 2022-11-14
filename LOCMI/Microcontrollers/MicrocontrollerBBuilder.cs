namespace LOCMI.Microcontrollers;

using LOCMI.Core;

internal sealed class MicrocontrollerBBuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = MicrocontrollerB.Connectors.ToList();

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        _microcontroller.Dimension = MicrocontrollerB.Dimension;

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
        _microcontroller.Identification = MicrocontrollerB.Identification;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        _microcontroller.Language = MicrocontrollerB.Language;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildName()
    {
        _microcontroller.Name = MicrocontrollerB.Name;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildPort()
    {
        _microcontroller.Ports = MicrocontrollerB.Ports;
        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildConnectors().BuildDimension().BuildDisk().BuildIdentification().BuildLanguage().BuildName().BuildPort();

        return _microcontroller;
    }
}