namespace LOCMI.Views;

public interface IView
{
    public static void Clear()
    {
        /*
        Console.WriteLine(@"        _                                _             _ _               __        __ _                          ");
        Console.WriteLine(@"  /\/\ (_) ___ _ __ ___   ___ ___  _ __ | |_ _ __ ___ | | | ___ _ __    / _\ ___  / _| |___      ____ _ _ __ ___ ");
        Console.WriteLine(@" /    \| |/ __| '__/ _ \ / __/ _ \| '_ \| __| '__/ _ \| | |/ _ | '__|   \ \ / _ \| |_| __\ \ /\ / / _` | '__/ _ \");
        Console.WriteLine(@"/ /\/\ | | (__| | | (_) | (_| (_) | | | | |_| | | (_) | | |  __| |      _\ | (_) |  _| |_ \ V  V | (_| | | |  __/");
        Console.WriteLine(@"\/    \|_|\___|_|  \___/ \___\___/|_| |_|\__|_|  \___/|_|_|\___|_|      \__/\___/|_|  \__| \_/\_/ \__,_|_|  \___|");
        Console.WriteLine(@"                                                                                                                 ");
        */
        Console.Clear();
        Console.WriteLine(@" _                          _  ");
        Console.WriteLine(@"| |    ___   ___    _  _   (_) ");
        Console.WriteLine(@"| |   / _ \ / __|  / \/ \  | | ");
        Console.WriteLine(@"| |__| (_) | (__  / Ʌ  Ʌ \ | | ");
        Console.WriteLine(@"|____|\___/ \___|/_/ \/ \_\|_| ");
        Console.WriteLine(@"                                                                                                                 ");
    }

    public static void Display(string message)
    {
        Console.WriteLine(message);
    }

    public static string? GetUserEntry()
    {
        return Console.ReadLine();
    }
}