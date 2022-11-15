namespace LOCMI.Controllers;

using LOCMI.Views;

public class ScannerController
{
    private readonly IView _view;

    public ScannerController(IView view)
    {
        _view = view;
    }

    public string Run()
    {
        _view.Display("Enter information");
        return _view.GetUserEntry() ?? string.Empty;
    }
}