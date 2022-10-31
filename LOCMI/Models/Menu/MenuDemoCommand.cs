namespace LOCMI.Models.Menu.DemoMenu;

using LOCMI.Controllers;

public sealed class MenuDemoCommand : MainMenuCommand
{
    private DemoController _demoController;

    public MenuDemoCommand(DemoController demoController)
    {
        _demoController = demoController;
    }

    public override bool IsExecutable()
    {
        return false;
    }

    public new void Execute()
    {
        /* TODO */
    }
}