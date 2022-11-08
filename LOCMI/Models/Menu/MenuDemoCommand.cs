namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuDemoCommand : MainMenuCommand
{
    private readonly DemoController _demoController;

    public MenuDemoCommand(DemoController demoController)
    {
        _demoController = demoController;
    }

    public override Task Execute()
    {
        _demoController.Run();
        return Task.CompletedTask;
    }

    public override bool IsExecutable()
    {
        return false;
    }
}