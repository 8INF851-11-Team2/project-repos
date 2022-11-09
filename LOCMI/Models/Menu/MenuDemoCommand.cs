namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuDemoCommand : IMainMenuCommand
{
    private readonly DemoController _demoController;

    public MenuDemoCommand(DemoController demoController)
    {
        _demoController = demoController;
    }

    public void Execute()
    {
        _demoController.Run();
    }

    public bool IsExecutable()
    {
        return false;
    }
}