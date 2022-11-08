namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuExpCommand : MainMenuCommand
{
    private readonly ExperimentalController _expController;

    public MenuExpCommand(ExperimentalController experimentalController)
    {
        _expController = experimentalController;
    }

    public override void Execute()
    {
        _expController.Run();
    }

    public override bool IsExecutable()
    {
        return false;
    }
}