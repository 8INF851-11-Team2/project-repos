namespace LOCMI.Views;

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
    public string? GetUserEntry()
    {
        return Console.ReadLine();
    }
}