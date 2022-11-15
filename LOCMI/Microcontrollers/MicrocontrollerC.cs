namespace LOCMI.Microcontrollers;

using LOCMI.Core.Utils;
using LOCMI.Core.Utils.PortTypes;

public static class MicrocontrollerC
{
    public static IEnumerable<Connector> Connectors => new List<Connector>
    {
        new ("USB-C"),
        new ("Ethernet"),
    };

    public static Dimension Dimension => new (10, 20, 30, 40);

    public static Identification Identification => new ("NXP", "LPC5500 Series");

    public static IEnumerable<Language> Languages => new List<Language>
    {
        new ("java", "17.0"),
    };

    public static string Name => "MicrocontrollerC";

    public static Ports Ports => new ()
    {
        { 0, new GroundPort() },
        { 1, new PowerPort(3.3) },
        { 2, new DataPort() },
        { 3, new GroundPort() },
    };
}