namespace MicrocontrollerD;

using JetBrains.Annotations;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

[UsedImplicitly]
public class MicrocontrollerDBuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = MicrocontrollerD.Connectors.Select(static c => new Connector(c));

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        _microcontroller.Dimension = MicrocontrollerD.Dimension;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDisk()
    {
        _microcontroller.ExternalHardDisk = MicrocontrollerD.Disk;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildIdentification()
    {
        _microcontroller.Identification = MicrocontrollerD.Identification;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        _microcontroller.Languages = MicrocontrollerD.Languages.Select(static c => new Language(c.Language, c.Version));

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildMaintenance()
    {
        _microcontroller.IsMaintainable = MicrocontrollerD.IsMaintainable;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildName()
    {
        _microcontroller.Name = MicrocontrollerD.Name;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildOS()
    {
        _microcontroller.OS = MicrocontrollerD.OS;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildPort()
    {
        _microcontroller.Ports = new Ports();

        foreach ((int numPin, Port port) in MicrocontrollerD.Ports)
        {
            _microcontroller.Ports.Add(numPin, port);
        }

        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildConnectors().BuildDimension().BuildDisk().BuildIdentification().BuildLanguage().BuildMaintenance().BuildName().BuildOS().BuildPort();

        return _microcontroller;
    }
}