namespace MicrocontrollerD;

using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public static class MicrocontrollerD
{
    public const bool IsMaintainable = true;

    public const string Name = "MicrocontrollerD";

    public static readonly IEnumerable<string> Connectors = new List<string>
    {
        "HDMI",
        "USB-C",
        "RJ45",
    };

    public static readonly Dimension Dimension = new (10.5, 5.5, 0.75, 20);

    public static readonly Disk Disk = new ("SSD");

    public static readonly Identification Identification = new ("LOCMI", "MC-00743-T");

    public static readonly IEnumerable<(string Language, string Version)> Languages = new List<(string, string)>
    {
        ("java", "17"),
        ("python", "13"),
    };

    public static readonly OS OS = new ("Raspberry");

    public static readonly IEnumerable<(int NumPin, Port Port)> Ports = new List<(int, Port)>
    {
        (1, new DataPort()),
        (2, new PowerPort(3.3)),
        (3, new DataPort()),
        (4, new DataPort()),
        (5, new PowerPort(5)),
        (6, new DataPort()),
        (7, new DataPort()),
        (8, new DataPort()),
        (9, new OtherPort()),
        (10, new OtherPort()),
        (11, new DataPort()),
        (12, new DataPort()),
        (13, new GroundPort()),
        (14, new OtherPort()),
        (15, new OtherPort()),
        (16, new OtherPort()),
    };
}