namespace LOCMI.Views;

public sealed class View
{
    public View()
    {
        Console.WriteLine("************* Microcontroller Software *************");
    }

    public void Display(string message)
    {
        Console.WriteLine(message);
    }
}