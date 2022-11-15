namespace LOCMI.Controllers;

using LOCMI.Models.Menu;
using LOCMI.Models.Menu.ExpMenu;
using LOCMI.Views;

public sealed class ExperimentalController : MenuController<IExpMenuCommand>
{
    public ExperimentalController()
        : base(false)
    {
    }

    protected override Menu<IExpMenuCommand> SetMenu()
    {
        var loadTestCommand = new LoadTestCommand();
        var runTestCommand = new RunTestCommand();
        var loadMicroControllerCommand = new LoadMicrocontrollerCommand();

        return new Menu<IExpMenuCommand>("Experimental Menu")
        {
            { "Load Test", loadTestCommand },
            { "Run Test", runTestCommand },
            { "Load Microcontroller Test", loadMicroControllerCommand },
        };
    }
}