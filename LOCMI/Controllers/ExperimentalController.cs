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
            List<Entry<IExpMenuCommand>> entries = _menuExperimental.GetEntries();
            _view.Display("\nChoose a choice from the menu below:");
            /* display entries */
            entries.ForEach(static entry => entry.Show());
            /* Read the user's choice */
            string? read = Console.ReadLine();
            var userChoice = Convert.ToInt32(read);
            /* Execute the user's choice */
            _menuExperimental.Execute(userChoice);
        }
    }
}