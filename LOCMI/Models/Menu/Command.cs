namespace LOCMI.Models.Menu;

public interface ICommand
{
    public Task Execute();

    public bool IsExecutable();
}