namespace LOCMI.Controllers;

using LOCMI.Views;

public sealed class ScannerController
{
    private readonly View _view;

    public ScannerController()
    {
        _view = new View();
    }

    public string Run()
    {
        _view.Display("Enter information");
        return Console.ReadLine() ?? string.Empty;
    }
}