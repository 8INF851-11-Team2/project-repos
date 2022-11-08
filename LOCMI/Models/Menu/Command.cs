namespace LOCMI.Models.Menu;

public interface ICommand
{
    public void Execute();

    public bool IsExecutable();
}