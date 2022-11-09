namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuExpCommand : IMainMenuCommand
{
    private readonly ExperimentalController _expController;

    public MenuExpCommand(ExperimentalController experimentalController)
    {
        _expController = experimentalController;
    }

    public void Execute()
    {
        _expController.Run();
    }

    public bool IsExecutable()
    {
        return false;
    }
}