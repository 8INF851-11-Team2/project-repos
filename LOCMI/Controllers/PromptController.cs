namespace LOCMI.Controllers;

using LOCMI.Views;

public class PromptController
{

    public static void Run(string msgToPrint)
    {
        IView.Display(msgToPrint);
    }
}