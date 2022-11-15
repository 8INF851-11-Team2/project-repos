namespace LOCMI.Controllers;

using LOCMI.Views;

public class ScannerController
{
    public static string Run()
    {
        IView.Display("Enter information");
        return IView.GetUserEntry() ?? string.Empty;
    }
}