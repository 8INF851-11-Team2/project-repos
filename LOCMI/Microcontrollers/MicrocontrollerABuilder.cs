namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers;

internal sealed class MicrocontrollerABuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = MicrocontrollerA.Connectors.ToList();

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        _microcontroller.Dimension = MicrocontrollerA.Dimension;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDisk()
    {
        _microcontroller.Disk = MicrocontrollerA.Disk;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildIdentification()
    {
        _microcontroller.Identification = MicrocontrollerA.Identification;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        _microcontroller.Languages = MicrocontrollerA.Languages;

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
        _microcontroller.Name = MicrocontrollerA.Name;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildOS()
    {
        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildPort()
    {
        _microcontroller.Ports = MicrocontrollerA.Ports;
        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildConnectors().BuildDimension().BuildDisk().BuildIdentification().BuildLanguage().BuildMaintenance().BuildName().BuildOS().BuildPort();

        return _microcontroller;
    }
}