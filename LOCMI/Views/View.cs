namespace LOCMI.Views;

public sealed class View
{
    public View()
    {
        /*
        Console.WriteLine(@"        _                                _             _ _               __        __ _                          ");
        Console.WriteLine(@"  /\/\ (_) ___ _ __ ___   ___ ___  _ __ | |_ _ __ ___ | | | ___ _ __    / _\ ___  / _| |___      ____ _ _ __ ___ ");
        Console.WriteLine(@" /    \| |/ __| '__/ _ \ / __/ _ \| '_ \| __| '__/ _ \| | |/ _ | '__|   \ \ / _ \| |_| __\ \ /\ / / _` | '__/ _ \");
        Console.WriteLine(@"/ /\/\ | | (__| | | (_) | (_| (_) | | | | |_| | | (_) | | |  __| |      _\ | (_) |  _| |_ \ V  V | (_| | | |  __/");
        Console.WriteLine(@"\/    \|_|\___|_|  \___/ \___\___/|_| |_|\__|_|  \___/|_|_|\___|_|      \__/\___/|_|  \__| \_/\_/ \__,_|_|  \___|");
        Console.WriteLine(@"                                                                                                                 ");
        */
        Console.WriteLine(@" _                          _  ");
        Console.WriteLine(@"| |    ___   ___    _  _   (_) ");
        Console.WriteLine(@"| |   / _ \ / __|  / \/ \  | | ");
        Console.WriteLine(@"| |__| (_) | (__  / Ʌ  Ʌ \ | | ");
        Console.WriteLine(@"|____|\___/ \___|/_/ \/ \_\|_| ");
        Console.WriteLine(@"                                                                                                                 ");
    }

    public void Display(string message)
    {
        Console.WriteLine(message);
    }

    public string? GetUserEntry()
    {
        return Console.ReadLine();
    }
}