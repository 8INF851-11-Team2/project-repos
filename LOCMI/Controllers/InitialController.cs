namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Views;

public sealed class InitialController : MenuController<IMainMenuCommand>
{
    public InitialController(View view)
        : base(view)
    {
    }

    /// <inheritdoc />
    protected override Menu<IMainMenuCommand> SetMenu()
    {
        var demoController = new DemoController(View);
        var expController = new ExperimentalController(View);

        var demoCommand = new MenuDemoCommand(demoController);
        var expCommand = new MenuExpCommand(expController);

        return new Menu<IMainMenuCommand>("Main Menu")
        {
            { "Display the demo menu", demoCommand },
            { "Display the experimental menu", expCommand },
        };
    }
}