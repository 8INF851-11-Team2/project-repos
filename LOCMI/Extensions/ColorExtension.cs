namespace LOCMI.Extensions;

using System.Drawing;

public static class ColorExtension
{
    public static ConsoleColor ToConsoleColor(this Color color)
    {
        ConsoleColor output = 0;

        double r = color.R;
        double g = color.G;
        double b = color.B;

        var delta = double.MaxValue;

        foreach (ConsoleColor consoleColor in Enum.GetValues(typeof(ConsoleColor)))
        {
            string? consoleColorName = Enum.GetName(typeof(ConsoleColor), consoleColor);

            if (string.IsNullOrEmpty(consoleColorName))
            {
                continue;
            }

            Color c = Color.FromName(consoleColorName == "DarkYellow"
                                         ? "Orange"
                                         : consoleColorName);

            double t = Math.Pow(c.R - r, 2.0) + Math.Pow(c.G - g, 2.0) + Math.Pow(c.B - b, 2.0);

            if (t == 0.0)
            {
                return consoleColor;
            }

            if (t < delta)
            {
                delta = t;
                output = consoleColor;
            }
        }

        return output;
    }
}