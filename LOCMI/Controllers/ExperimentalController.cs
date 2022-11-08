namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Models.Menu.ExpMenu;
using LOCMI.Views;

public sealed class ExperimentalController
{
    private readonly View _view;

    private Menu<IExpMenuCommand> _menuExperimental;

    public ExperimentalController(View view)
    {
        _view = view;
    }

    public void Run()
    {
        var loadTestCommand = new LoadTestCommand();
        var runTestCommand = new RunTestCommand();
        var loadMicroControllerCommand = new LoadMicrocontrollerCommand();

        _menuExperimental = new Menu<IExpMenuCommand>("Experimental Menu")
        {
            { "Load Test", loadTestCommand },
            { "Run Test", runTestCommand },
            { "Load Microcontroller Test", loadMicroControllerCommand },
        };

        while (!_menuExperimental.IsClosed)
        {
            _view.Display("\nChoose a choice from the menu below:");

            foreach ((string displayText, _) in _menuExperimental)
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
                    _menuExperimental.Execute(userChoice - 1);
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