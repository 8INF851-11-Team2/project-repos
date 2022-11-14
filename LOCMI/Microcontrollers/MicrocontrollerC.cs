namespace LOCMI.Microcontrollers;

using LOCMI.Core.Utils;

public sealed class MicrocontrollerC
{
    public static IEnumerable<Connector> Connectors => new List<Connector>
    {
        new ("USB-C"), new ("Ethernet"),
    };

    public static Dimension Dimension => new (10, 20, 30, 40);

    public static Disk Disk => new ("SSD");

    public static Identification Identification => new ("NXP", "LPC5500 Series");

    public static Language Language => new ("english", "1.0");

    public static string Name => "MicrocontrollerC";

    public static Ports Ports => new ()
    {
        { 0, EPortType.Ground },
        { 1, EPortType.Power },
        { 2, EPortType.Data },
        { 3, EPortType.Data },
    };
}