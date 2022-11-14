namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public sealed class InitialController : MenuController<IMainMenuCommand>
{
    public InitialController()
    {
    }

    /// <inheritdoc />
    protected override Menu<IMainMenuCommand> SetMenu()
    {
        var demoController = new DemoController();
        var expController = new ExperimentalController();

        var demoCommand = new MenuDemoCommand(demoController);
        var expCommand = new MenuExpCommand(expController);

        return new Menu<IMainMenuCommand>("Main Menu")
        {
            { "Display the demo menu", demoCommand },
            { "Display the experimental menu", expCommand },
        };
    }
}