namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public class MenuDemoCommand : MainMenuCommand
{
    private DemoController _demoController;

    public MenuDemoCommand() { }

    public MenuDemoCommand(DemoController demoController)
    {
        _demoController = demoController;
    }

    public override bool IsExecutable()
    {
        return false;
    }

    public override void Execute()
    {
        _demoController.Run();
    }

}