namespace MicrocontrollerD;

using JetBrains.Annotations;
using LOCMI.Core.Microcontrollers;
using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

[UsedImplicitly]
public class MicrocontrollerD : Microcontroller
{
    /// <inheritdoc />
    public override IEnumerable<Connector>? Connectors { get; set; } = new List<Connector>
    {
        new ("HDMI"),
        new ("USB-C"),
        new ("RJ45"),
    };

    /// <inheritdoc />
    public override Dimension? Dimension { get; set; } = new Dimension(10.5, 5.5, 0.75, 20);

    /// <inheritdoc />
    public override Disk? Disk { get; set; } = new Disk("SSD");

    /// <inheritdoc />
    public override Identification? Identification { get; set; } = new Identification("LOCMI", "MC-00743-T");

    /// <inheritdoc />
    public override bool IsMaintainable { get; set; } = true;

    /// <inheritdoc />
    public override IEnumerable<Language>? Languages { get; set; } = new List<Language>
    {
        new ("java", "17"),
        new ("python", "13"),
    };

    /// <inheritdoc />
    public override string? Name { get; set; } = "MicrocontrollerD";

    /// <inheritdoc />
    public override OS? OS { get; set; } = new OS("Raspberry");

    /// <inheritdoc />
    public override Ports? Ports { get; set; } = new ()
    {
        { 1, new DataPort() },
        { 2, new PowerPort(3.3) },
        { 3, new DataPort() },
        { 4, new DataPort() },
        { 5, new PowerPort(5) },
        { 6, new DataPort() },
        { 7, new DataPort() },
        { 8, new DataPort() },
        { 9, new OtherPort() },
        { 10, new OtherPort() },
        { 11, new DataPort() },
        { 12, new DataPort() },
        { 13, new GroundPort() },
        { 14, new OtherPort() },
        { 15, new OtherPort() },
        { 16, new OtherPort() },
    };
}