namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuExpCommand : MainMenuCommand
{
    private readonly ExperimentalController _expController;

    public MenuExpCommand(ExperimentalController experimentalController)
    {
        _expController = experimentalController;
    }

    public override Task Execute()
    {
        _expController.Run();
        return Task.CompletedTask;
    }

    public override bool IsExecutable()
    {
        return false;
    }
}