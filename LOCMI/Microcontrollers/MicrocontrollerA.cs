namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public static class MicrocontrollerA
{
    public static IEnumerable<Connector> Connectors => new List<Connector>
    {
        new ("HDMI"),
        new ("USB"),
        new ("Wifi"),
    };

    public static Dimension Dimension => new (4.52, 2.09, 0.8, 100);

    public static Disk Disk => new ("SD Card");

    public static Identification Identification => new ("Raspberry PI", "RP4000");

    public static IEnumerable<Language> Languages => new List<Language>
    {
        new ("python", "3.11.0"),
    };

    public static string Name => "MicrocontrollerA";

    public static Ports Ports => new ()
    {
        { 1, new PowerPort(3.3) },
        { 2, new DataPort() },
        { 3, new DataPort() },
        { 4, new DataPort() },
        { 5, new DataPort() },
        { 6, new DataPort() },
        { 7, new OtherPort() },
        { 8, new GroundPort() },
        { 9, new GroundPort() },
        { 10, new OtherPort() },
        { 11, new OtherPort() },
        { 12, new DataPort() },
        { 13, new DataPort() },
        { 14, new OtherPort() },
        { 15, new OtherPort() },
        { 16, new OtherPort() },
    };
}