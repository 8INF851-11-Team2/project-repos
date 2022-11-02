namespace LOCMI.Controllers;

using LOCMI.Models.Menu.DemoMenu;
using LOCMI.Models.Menu;
using LOCMI.Views;

public sealed class DemoController
{
    private Menu<IDemoMenuCommand> _menuDemo;

    private View _view;

    public DemoController(View view)
    {
        _view = view;
    }

    public void Run()
    {
        _menuDemo = new Menu<IDemoMenuCommand>("Demonstration Menu");
        TestingAllCommand testingAllCommand = new TestingAllCommand();
        TestingIndividualCommand testingIndividualCommand = new TestingIndividualCommand();
        _menuDemo.Add("Testing All", testingAllCommand);
        _menuDemo.Add("Testing Individual", testingIndividualCommand);

        while (!_menuDemo.GetIsClosed())
        { 

            List<Entry<IDemoMenuCommand>> entries = _menuDemo.GetEntries();
            _view.Display("\nChoose a choice from the menu below:");
            /* display entries */
            entries.ForEach(static entry => entry.Show());
            /* Read the user's choice */
            string? read = Console.ReadLine();
            var userChoice = Convert.ToInt32(read);
            /* Execute the user's choice */
            _menuDemo.Execute(userChoice - 1);
        }

    }
}