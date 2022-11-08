namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public sealed class InitialController
{
    private Menu<IMainMenuCommand>? _mainMenu;

    private View? _view;

    public void Run()
    {
        _view = new View();

        var demoController = new DemoController(_view);
        var expController = new ExperimentalController(_view);

        var demoCommand = new MenuDemoCommand(demoController);
        var expCommand = new MenuExpCommand(expController);

        _mainMenu = new Menu<IMainMenuCommand>("Main Menu")
        {
            { "Display the demo menu", demoCommand },
            { "Display the experimental menu", expCommand },
        };

        while (!_mainMenu.IsClosed)
        {
            _view.Display("\nChoose a choice from the menu below:");

            foreach ((string displayText, _) in _mainMenu)
            {
                _view.Display("-------->  " + displayText);
            }

            string? read;

            do
            {
                read = _view.GetUserEntry();
            } while (!string.IsNullOrEmpty(read));

            if (!string.IsNullOrEmpty(read))
            {
                try
                {
                    int userChoice = int.Parse(read);
                    _mainMenu.Execute(userChoice - 1);
                }
                catch (Exception e)
                {
                    if (e is ArgumentOutOfRangeException or FormatException)
                    {
                        _view.Display("Please enter a valid choice");
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
    }
}