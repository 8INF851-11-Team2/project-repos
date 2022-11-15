namespace LOCMI.Microcontrollers;

using LOCMI.Core;

internal sealed class MicrocontrollerCBuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = MicrocontrollerC.Connectors.ToList();

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        _microcontroller.Dimension = MicrocontrollerC.Dimension;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDisk()
    {
        _microcontroller.Disk = null;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildIdentification()
    {
        _microcontroller.Identification = MicrocontrollerC.Identification;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        _microcontroller.Languages = MicrocontrollerC.Languages;

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
        _microcontroller.Name = MicrocontrollerC.Name;

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
        _microcontroller.Ports = MicrocontrollerC.Ports;
        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildConnectors().BuildDimension().BuildDisk().BuildIdentification().BuildLanguage().BuildMaintenance().BuildName().BuildOS().BuildPort();

        return _microcontroller;
    }
}