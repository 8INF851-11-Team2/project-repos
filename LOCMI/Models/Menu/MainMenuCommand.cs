namespace LOCMI.Models.Menu;

using LOCMI.Controllers;

public abstract class MainMenuCommand : ICommand
{
    protected InitialController Controller;

    public abstract void Execute();
    public abstract bool IsExecutable();
}