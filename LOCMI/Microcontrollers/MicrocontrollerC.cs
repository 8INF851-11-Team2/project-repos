namespace LOCMI.Microcontrollers;

using LOCMI.Core.Microcontrollers.Utils;

public static class MicrocontrollerC
{
    public const string Connector = "MicroUSB";

    public const double Height = 0.68;

    public const double Length = 1.72;

    public const string Name = "MicrocontrollerC";

    public const int Weight = 82;

    public const double Width = 3.8;

    public static readonly Disk Disk = new ();

    public static readonly Dictionary<int, string> GPIO = new ()
    {
        { 1, "VIN" },
        { 2, "GRN" },
        { 3, "DATA" },
        { 4, "DATA" },
        { 5, "DATA" },
        { 6, "DATA" },
        { 7, "OTHER" },
        { 8, "GRN" },
        { 9, "DATA" },
        { 10, "DATA" },
        { 11, "DATA" },
        { 12, "OTHER" },
    };

    public static readonly (string Brand, string Model) Identification = ("Arduino", "AR1240");

    public static readonly (string Language, string Version) Language = ("C++", string.Empty);

    public static readonly Dictionary<int, double> Powers = new ()
    {
        { 1, 3.3 },
        { 7, 5 },
    };
}