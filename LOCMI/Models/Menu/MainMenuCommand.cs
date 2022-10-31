namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public abstract class MainMenuCommand : ICommand
{
    protected InitialController Controller;

    public void Execute()
    {
    }

    public virtual bool IsExecutable()
    {
        return false;
    }
}