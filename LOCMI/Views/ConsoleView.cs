namespace LOCMI.Views;

using System.Drawing;
using LOCMI.Extensions;

public sealed class ConsoleView : IView
{
    /// <inheritdoc />
    public void Clear()
    {
        Console.Clear();

        Console.WriteLine(@" _                          _  ");
        Console.WriteLine(@"| |    ___   ___    _  _   (_) ");
        Console.WriteLine(@"| |   / _ \ / __|  / \/ \  | | ");
        Console.WriteLine(@"| |__| (_) | (__  / Ʌ  Ʌ \ | | ");
        Console.WriteLine(@"|____|\___/ \___|/_/ \/ \_\|_| ");
    }

    /// <inheritdoc />
    public void Display(string message)
    {
        Console.WriteLine(message);
    }

    /// <inheritdoc />
    public void Display(string message, Color textColor)
    {
        ConsoleColor currentTextColor = Console.ForegroundColor;

        Console.ForegroundColor = textColor.ToConsoleColor();
        Display(message);
        Console.ForegroundColor = currentTextColor;
    }

    /// <inheritdoc />
    public void Display(string message, Color textColor, Color backColor)
    {
        ConsoleColor currentTextColor = Console.ForegroundColor;
        ConsoleColor currentBackColor = Console.BackgroundColor;

        Console.ForegroundColor = textColor.ToConsoleColor();
        Console.BackgroundColor = backColor.ToConsoleColor();

        Console.Write(message);

        Console.BackgroundColor = currentBackColor;
        Console.ForegroundColor = currentTextColor;

        Console.WriteLine();
    }

    /// <inheritdoc />
    public string? GetUserEntry()
    {
        return Console.ReadLine();
    }
}