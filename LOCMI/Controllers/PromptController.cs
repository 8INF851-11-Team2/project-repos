namespace LOCMI.Controllers;

using LOCMI.Views;

public class PromptController
{
    private readonly View _view;

    public PromptController()
    {
        _view = new View();
    }

    public void Run(string msgToPrint)
    {
        _view.Display(msgToPrint);
    }
}