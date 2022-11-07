namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Views;

internal class PromptController
{
    private View _view;

    public void Run(string msgToPrint)
    {
        _view = new View();
        _view.Display(msgToPrint);
    }
}
