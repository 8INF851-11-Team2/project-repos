namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuDemoCommand : MainMenuCommand
{
    private readonly DemoController _demoController;

    public MenuDemoCommand(DemoController demoController)
    {
        _demoController = demoController;
    }

    public override void Execute()
    {
        _demoController.Run();
    }

    public override bool IsExecutable()
    {
        return false;
    }
}