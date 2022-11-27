namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

internal sealed class MicrocontrollerCBuilder : IMicrocontrollerAdapter
{
    private readonly Microcontroller _microcontroller = new ();

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildConnectors()
    {
        _microcontroller.Connectors = new[] { new Connector(MicrocontrollerC.Connector) };

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDimension()
    {
        _microcontroller.Dimension = new Dimension(MicrocontrollerC.Length, MicrocontrollerC.Width, MicrocontrollerC.Height, MicrocontrollerC.Weight);

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildDisk()
    {
        _microcontroller.Disk = MicrocontrollerC.Disk;

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildIdentification()
    {
        (string? brand, string? model) = MicrocontrollerC.Identification;

        _microcontroller.Identification = new Identification(brand, model);

        return this;
    }

    /// <inheritdoc />
    public IMicrocontrollerAdapter BuildLanguage()
    {
        (string? language, string? version) = MicrocontrollerC.Language;

        _microcontroller.Languages = new List<Language>
        {
            new (language, version),
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
        _microcontroller.Ports = new Ports();

        MicrocontrollerC.GPIO.Select(static c =>
                        {
                            (int key, string value) = c;

                            Port port = value switch
                            {
                                "VIN" => new PowerPort(MicrocontrollerC.Powers.Where(p => p.Key == key).Select(static p => p.Value).First()),
                                "GRN" => new GroundPort(),
                                "DATA" => new GroundPort(),
                                _ => new OtherPort(),
                            };

                            return new
                            {
                                NumPin = key,
                                Port = port,
                            };
                        })
                        .ToList()
                        .ForEach(c => _microcontroller.Ports.Add(c.NumPin, c.Port));

        return this;
    }

    /// <inheritdoc />
    public Microcontroller GetResult()
    {
        BuildConnectors().BuildDimension().BuildDisk().BuildIdentification().BuildLanguage().BuildMaintenance().BuildName().BuildOS().BuildPort();

        return _microcontroller;
    }
}