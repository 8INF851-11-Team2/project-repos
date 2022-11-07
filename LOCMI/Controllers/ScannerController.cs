namespace LOCMI.Controllers;

using LOCMI.Views;

public sealed class ScannerController
{
    private readonly View _view;

    public ScannerController(View view)
    {
        _view = view;
    }

    public string Run()
    {
        _view.Display("Enter information");
        return Console.ReadLine() ?? string.Empty;
    }
}