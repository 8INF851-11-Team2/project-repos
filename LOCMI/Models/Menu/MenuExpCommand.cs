namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public sealed class MenuExpCommand : MainMenuCommand
{
    private ExperimentalController _expController;

    public MenuExpCommand(ExperimentalController experimentalController)
    {
        _expController = experimentalController;
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