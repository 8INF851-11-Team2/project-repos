namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers.Utils;
using LOCMI.Core.Microcontrollers.Utils.PortTypes;

public static class MicrocontrollerB
{
    public const string Brand = "Raspberry PI";

    public const bool HasIntegratedHardDisk = true;

    public const bool IsMaintainable = true;

    public const string Language = "C++";

    public const string LanguageVersion = "17";

    public const string Model = "RP2000";

    public const string Name = "MicrocontrollerB";

    public static readonly string[] Connectors = { "HDMI", "USB", "Wifi", "Bluetooth" };

    public static readonly (int Weight, int Length, double Width, double Height) Dimension = (182, 6, 2.9, 0.77);

    public static readonly OS OS = new ();

    public static Ports GPIO => new ()
    {
        { 1, new DataPort() },
        { 2, new DataPort() },
        { 3, new DataPort() },
        { 4, new DataPort() },
        { 5, new DataPort() },
        { 6, new DataPort() },
        { 7, new DataPort() },
        { 8, new DataPort() },
        { 9, new PowerPort(3.3) },
        { 10, new PowerPort(5) },
        { 11, new DataPort() },
        { 12, new DataPort() },
        { 13, new OtherPort() },
        { 14, new OtherPort() },
        { 15, new OtherPort() },
        { 16, new OtherPort() },
        { 17, new OtherPort() },
        { 18, new OtherPort() },
        { 19, new GroundPort() },
        { 20, new GroundPort() },
    };
}