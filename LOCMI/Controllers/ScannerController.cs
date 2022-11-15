namespace LOCMI.Controllers;

using LOCMI.Views;

public sealed class ScannerController
{

    public ScannerController()
    {
    }

    public string Run()
    {
        IView.Display("Enter information");
        return IView.GetUserEntry() ?? string.Empty;
    }
}